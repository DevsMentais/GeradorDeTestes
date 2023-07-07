﻿using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.Infra.Dados.Sql.Compartilhado;
using Microsoft.Data.SqlClient;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloQuestoes
{
    public class RepositorioQuestaoEmSql : RepositorioEmSqlBase<Questao, MapeadorQuestao>,IRepositorioQuestao
    {
        protected override string sqlInserir => @"INSERT INTO[DBO].[TBQUESTOES]
                                                    (
                                                       [MATERIA_ID]
                                                       ,[ENUNCIADO]
                                                       ,[RESPOSTA]
                                                    )
                                                 VALUES
                                                    (
                                                       @MATERIA_ID
                                                       ,@ENUNCIADO
                                                       ,@RESPOSTACERTA
                                                    );
                                                 SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar => @"UPDATE[TBQUESTOES]
                                               SET
                                                   [MATERIA_ID] = @MATERIA_ID
                                                  ,[ENUNCIADO] = @ENUNCIADO
                                                  ,[RESPOSTA] = @RESPOSTACERTA
                                             WHERE [ID] = @ID;";

        protected override string sqlExcluir => @"DELETE FROM [TBQUESTOES]
	                                                WHERE 
		                                                [ID] = @ID";

        protected override string sqlSelecionarTodos => @"SELECT 
	                                                        Q.[ID]                QUESTAO_ID 
	                                                       ,Q.[MATERIA_ID]        MATERIA_ID
	                                                       ,Q.[ENUNCIADO]         QUESTAO_ENUNCIADO
                                                           ,Q.[RESPOSTA]          QUESTAO_RESPOSTA
                                                           ,M.[NOME]              MATERIA_NOME
                                                           ,M.[SERIE]             MATERIA_SERIE
                                                           ,M.[DISCIPLINA_ID]     DISCIPLINA_ID
                                                           ,D.[NOME]   DISCIPLINA_NOME
                                                        FROM 
	                                                        [TBQUESTOES] AS Q
                                                        INNER JOIN [TBMATERIA] AS M
                                                                ON Q.[MATERIA_ID] = M.ID
                                                        INNER JOIN [TBDISCIPLINA] AS D
                                                                ON M.[DISCIPLINA_ID] = D.ID";

        protected override string sqlSelecionarPorId => @"SELECT 
	                                                        Q.[ID]                QUESTAO_ID 
	                                                       ,Q.[MATERIA_ID]        MATERIA_ID
	                                                       ,Q.[ENUNCIADO]         QUESTAO_ENUNCIADO
                                                           ,Q.[RESPOSTA]          QUESTAO_RESPOSTA
                                                           ,M.[NOME]              MATERIA_NOME
                                                           ,M.[SERIE]             MATERIA_SERIE
                                                           ,M.[DISCIPLINA_ID]     DISCIPLINA_ID
                                                           ,D.[NOME]   DISCIPLINA_NOME
                                                    FROM 
	                                                        [TBQUESTOES] AS Q
                                                        INNER JOIN [TBMATERIA] AS M
                                                                ON Q.[MATERIA_ID] = M.ID
                                                        INNER JOIN [TBDISCIPLINA] AS D
                                                                ON M.[DISCIPLINA_ID] = D.ID
                                                    WHERE 
                                                        Q.[ID] = @ID";

        private string sqlAdicionarAlternativa =>
            @"INSERT INTO [TBAlternativa]
                (
                   [LETRA]
                   ,[QUESTAO_ID]
                   ,[RESPOSTA]
                   ,[CORRETA]
                )
            VALUES
                (
                   @LETRA
                   ,@QUESTAO_ID
                   ,@RESPOSTA
                   ,@CORRETA
                )";

        private string sqlCarregarAlternativas =>
            @"SELECT 
                A.ID            ALTERNATIVA_ID, 
                A.LETRA         ALTERNATIVA_LETRA, 
                A.QUESTAO_ID    QUESTAO_ID,
                A.RESPOSTA      ALTERNATIVA_RESPOSTA,
                A.CORRETA       ALTERNATIVA_CORRETA,

                Q.MATERIA_ID    MATERIA_ID,
                Q.ENUNCIADO     QUESTAO_ENUNCIADO,
                Q.RESPOSTA      QUESTAO_RESPOSTA,

                M.NOME           MATERIA_NOME,
                M.DISCIPLINA_ID  DISCIPLINA_ID,
                M.SERIE          MATERIA_SERIE,

                D.NOME           DISCIPLINA_NOME
            FROM 
                TBALTERNATIVA A

                INNER JOIN TBQUESTOES Q

                    ON Q.ID = A.QUESTAO_ID

                INNER JOIN TBMATERIA M

                    ON Q.MATERIA_ID = M.ID

                INNER JOIN TBDISCIPLINA D

                    ON M.DISCIPLINA_ID = D.ID
            WHERE 

                A.QUESTAO_ID = @QUESTAO_ID AND Q.MATERIA_ID = @MATERIA_ID AND M.DISCIPLINA_ID = @DISCIPLINA_ID";

        private const string sqlRemoverAlternativas =
            @"DELETE FROM TBALTERNATIVA 
                WHERE QUESTAO_ID = @QUESTAO_ID AND ALTERNATIVA_ID = @ALTERNATIVA_ID";

        public void Inserir(Questao questao, List<Alternativa> alternativasAdicionadas)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
            comandoInserir.CommandText = sqlInserir;

            MapeadorQuestao mapeador = new MapeadorQuestao();
            mapeador.ConfigurarParametros(comandoInserir, questao);

            object id = comandoInserir.ExecuteScalar();

            questao.id = Convert.ToInt32(id);

            conexaoComBanco.Close();

            foreach (Alternativa alternativa in alternativasAdicionadas)
            {
                AdicionarAlternativa(alternativa, questao);
            }
        }

        public void Editar(int id, Questao questao, List<Alternativa> alternativasMarcadas, List<Alternativa> AlternativasDesmarcadas)
        {
            foreach (Alternativa alternativaParaAdicionar in alternativasMarcadas)
            {
                if (questao.Contem(alternativaParaAdicionar))
                    continue;

                AdicionarAlternativa(alternativaParaAdicionar, questao);
                questao.AdicionarAlternativa(alternativaParaAdicionar);
            }


            foreach (Alternativa alternativaParaAdicionar in AlternativasDesmarcadas)
            {
                if (questao.Contem(alternativaParaAdicionar))
                {
                    AdicionarAlternativa(alternativaParaAdicionar, questao);
                    questao.AdicionarAlternativa(alternativaParaAdicionar);
                }
            }


            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoEditar = conexaoComBanco.CreateCommand();
            comandoEditar.CommandText = sqlEditar;

            MapeadorQuestao mapeador = new MapeadorQuestao();
            mapeador.ConfigurarParametros(comandoEditar, questao);

            comandoEditar.ExecuteNonQuery();

            conexaoComBanco.Close();
        }

        public override Questao SelecionarPorId(int id)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoSelecionarPorId = conexaoComBanco.CreateCommand();
            comandoSelecionarPorId.CommandText = sqlSelecionarPorId;

            comandoSelecionarPorId.Parameters.AddWithValue("ID", id);

            SqlDataReader leitorTemas = comandoSelecionarPorId.ExecuteReader();

            Questao questao = null;

            if (leitorTemas.Read())
            {
                MapeadorQuestao mapeador = new MapeadorQuestao();
                questao = mapeador.ConverterRegistro(leitorTemas);
            }
                
            conexaoComBanco.Close();

            if (questao != null)
            {
                CarregarAlternativas(questao);
            }

            return questao;
        }

        public List<Questao> SelecionarTodos(bool carregarItens = false, bool carregarAlugueis = false)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoSelecionarTodos = conexaoComBanco.CreateCommand();
            comandoSelecionarTodos.CommandText = sqlSelecionarTodos;

            SqlDataReader leitorTemas = comandoSelecionarTodos.ExecuteReader();

            List<Questao> questoes = new List<Questao>();

            while (leitorTemas.Read())
            {
                MapeadorQuestao mapeador = new MapeadorQuestao();
                Questao questao = mapeador.ConverterRegistro(leitorTemas);

                if (carregarItens)
                    CarregarAlternativas(questao);

                questoes.Add(questao);
            }

            conexaoComBanco.Close();

            return questoes;
        }

        private void AdicionarAlternativa(Alternativa alternativa, Questao questao)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
            comandoInserir.CommandText = sqlAdicionarAlternativa;

            comandoInserir.Parameters.AddWithValue("LETRA", alternativa.Letra);
            comandoInserir.Parameters.AddWithValue("QUESTAO_ID", questao.id);
            comandoInserir.Parameters.AddWithValue("RESPOSTA", alternativa.Resposta);
            comandoInserir.Parameters.AddWithValue("CORRETA", alternativa.Correta);

            comandoInserir.ExecuteNonQuery();

            conexaoComBanco.Close();
        }

        private void CarregarAlternativas(Questao questao)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoSelecionarAlternativas = conexaoComBanco.CreateCommand();
            comandoSelecionarAlternativas.CommandText = sqlCarregarAlternativas;

            comandoSelecionarAlternativas.Parameters.AddWithValue("QUESTAO_ID", questao.id);
            comandoSelecionarAlternativas.Parameters.AddWithValue("MATERIA_ID", questao.Materia.id);
            comandoSelecionarAlternativas.Parameters.AddWithValue("DISCIPLINA_ID", questao.Materia.Disciplina.id);

            SqlDataReader leitorAlternativa = comandoSelecionarAlternativas.ExecuteReader();

            while (leitorAlternativa.Read())
            {
                MapeadorQuestao mapeador = new MapeadorQuestao();

                Alternativa alternativa = mapeador.ConverterParaAlternativa(leitorAlternativa);

                questao.AdicionarAlternativa(alternativa);
            }

            conexaoComBanco.Close();
        }

        
    }
}

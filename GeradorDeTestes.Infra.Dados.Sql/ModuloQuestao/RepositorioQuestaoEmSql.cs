﻿using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.Infra.Dados.Sql.Compartilhado;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloQuestoes
{
    public class RepositorioQuestaoEmSql : RepositorioEmSqlBase<Questao, MapeadorQuestao>,IRepositorioQuestao
    {
        protected override string sqlInserir => @"INSERT INTO[DBO].[TBQUESTOES]
                                                    (
                                                        [MATERIA_ID]
                                                       ,[ENUNCIADO]
                                                       ,[REPOSTA]
                                                    )
                                                 VALUES
                                                    (
                                                        @MATERIA_ID
                                                       ,@ENUNCIADO
                                                       ,@RESPOSTACERTA
                                                    );
                                                 SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar => throw new NotImplementedException();

        protected override string sqlExcluir => throw new NotImplementedException();

        protected override string sqlSelecionarTodos => @"SELECT 
	                                                        Q.[ID]                QUESTAO_ID 
	                                                       ,Q.[MATERIA_ID]        MATERIA_ID
	                                                       ,Q.[ENUNCIADO]         QUESTAO_ENUNCIADO
                                                           ,Q.[REPOSTA]     QUESTAO_RESPOSTACERTA
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

        protected override string sqlSelecionarPorId => throw new NotImplementedException();

        public Questao SelecionarPorId(int id)
        {
            Questao questao = base.SelecionarPorId(id);

            return questao;
        }

        public List<Questao> SelecionarTodos()
        {
            List<Questao> questoes = base.SelecionarTodos();

            return questoes;
        }
    }
}

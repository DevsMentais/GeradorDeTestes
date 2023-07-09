﻿using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.Infra.Dados.Sql.Compartilhado;
using GeradorDeTestes.Infra.Dados.Sql.ModuloQuestoes;
using Microsoft.Data.SqlClient;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloMateria
{
    public class RepositorioMateriaEmSql : RepositorioEmSqlBase<Materia, MapeadorMateria>,IRepositorioMateria
    {
        protected override string sqlInserir => @"INSERT INTO[DBO].[TBMATERIA]
                                                    (
                                                        [NOME]
                                                       ,[DISCIPLINA_ID]
                                                       ,[SERIE]
                                                    )
                                                 VALUES
                                                    (
                                                        @NOME
                                                       ,@DISCIPLINA_ID
                                                       ,@SERIE
                                                    );
                                                 SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar => @"UPDATE[TBMATERIA]
                                               SET
                                                   [NOME] = @NOME
                                                  ,[DISCIPLINA_ID] = @DISCIPLINA_ID
                                                  ,[SERIE] = @SERIE
                                             WHERE [ID] = @ID;";

        protected override string sqlExcluir => @"DELETE FROM [TBMATERIA]
	                                                WHERE 
		                                                [ID] = @ID";

        protected override string sqlSelecionarTodos => @"SELECT 
	                                                        M.[ID]        MATERIA_ID 
	                                                       ,M.[NOME]      MATERIA_NOME
	                                                       ,M.[DISCIPLINA_ID]  DISCIPLINA_ID
                                                           ,M.[SERIE]     MATERIA_SERIE
                                                           ,D.[NOME]        DISCIPLINA_NOME
                                                        FROM 
	                                                        [TBMATERIA] AS M
                                                        INNER JOIN [TBDISCIPLINA] AS D
                                                                ON M.[DISCIPLINA_ID] = D.ID";

        protected override string sqlSelecionarPorId => @"SELECT 
	                                                    M.[ID]        MATERIA_ID 
	                                                   ,M.[NOME]      MATERIA_NOME
	                                                   ,M.[DISCIPLINA_ID]  DISCIPLINA_ID
                                                       ,M.[SERIE]     MATERIA_SERIE
                                                       ,D.[NOME]      DISCIPLINA_NOME
                                                    FROM 
	                                                    [TBMATERIA] AS M
                                                    INNER JOIN [TBDISCIPLINA] AS D
                                                            ON M.[DISCIPLINA_ID] = D.ID
                                                    WHERE 
                                                        M.[ID] = @ID";

        private string sqlSelecionarMateriaNaDisciplina => @"SELECT 
                M.ID                    MATERIA_ID, 
                M.NOME                  MATERIA_NOME,
                M.DISCIPLINA_ID         DISCIPLINA_ID, 
                M.SERIE                 SERIE_ID,

                D.ID             DISCIPLINA_ID,
                D.NOME           DISCIPLINA_NOME
            FROM 
                TBMATERIA M

                INNER JOIN TBDISCIPLINA D

                    ON M.DISCIPLINA_ID = D.ID
            WHERE 

                M.ID = @MATERIA_ID AND D.ID = @DISCIPLINA_ID";

        public override List<Materia> SelecionarTodos()
        {
            List<Materia> materias = base.SelecionarTodos();

            return materias;
        }

        public override Materia SelecionarPorId(int id)
        {
            Materia materia = base.SelecionarPorId(id);

            return materia;
        }

        public void CarregarMateriasDisciplina(Materia materia)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoSelecionarMaterias = conexaoComBanco.CreateCommand();
            comandoSelecionarMaterias.CommandText = sqlSelecionarMateriaNaDisciplina;

            comandoSelecionarMaterias.Parameters.AddWithValue("DISCIPLINA_ID", materia.Disciplina.id);
            comandoSelecionarMaterias.Parameters.AddWithValue("MATERIA_ID", materia.id);

            SqlDataReader leitorMateria = comandoSelecionarMaterias.ExecuteReader();

            while (leitorMateria.Read())
            {
                MapeadorMateria mapeador = new MapeadorMateria();

                materia = mapeador.ConverterRegistro(leitorMateria);

                materia.Disciplina.ListMaterias.Add(materia);
            }

            conexaoComBanco.Close();
        }

    }
}

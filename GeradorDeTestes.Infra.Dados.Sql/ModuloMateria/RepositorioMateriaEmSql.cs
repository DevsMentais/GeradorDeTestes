using GeradorDeTestes.Dominio.ModuloDisciplina;
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

        private string sqlAdicionarMateriaNaDisciplina => @"SELECT 
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
            //obter a conexão com o banco e abrir ela
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            //cria um comando e relaciona com a conexão aberta
            SqlCommand comandoSelecionarMaterias = conexaoComBanco.CreateCommand();
            comandoSelecionarMaterias.CommandText = sqlAdicionarMateriaNaDisciplina;

            comandoSelecionarMaterias.Parameters.AddWithValue("DISCIPLINA_ID", materia.Disciplina.id);
            comandoSelecionarMaterias.Parameters.AddWithValue("MATERIA_ID", materia.id);

            //executa o comando
            SqlDataReader leitorMateria = comandoSelecionarMaterias.ExecuteReader();

            while (leitorMateria.Read())
            {
                MapeadorMateria mapeador = new MapeadorMateria();

                materia = mapeador.ConverterRegistro(leitorMateria);

                materia.Disciplina.ListMaterias.Add(materia);
            }
            

            //encerra a conexão
            conexaoComBanco.Close();
        }

    }
}

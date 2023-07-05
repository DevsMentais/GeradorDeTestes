using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.Infra.Dados.Sql.Compartilhado;
using GeradorDeTestes.Infra.Dados.Sql.ModuloDisciplina;
using GeradorDeTestes.Infra.Dados.Sql.ModuloMateria;
using Microsoft.Data.SqlClient;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloQuestoes
{
    public class MapeadorQuestao : MapeadorBase<Questao>
    {
        public override void ConfigurarParametros(SqlCommand comando, Questao registro)
        {
            comando.Parameters.AddWithValue("@ID", registro.id);
            comando.Parameters.AddWithValue("@MATERIA_ID", registro.Materia.id);
            comando.Parameters.AddWithValue("@ENUNCIADO", registro.Enunciado);
            comando.Parameters.AddWithValue("@RESPOSTACERTA", registro.RespostaCerta);
        }

        public override Questao ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["QUESTAO_ID"]);
            string enunciado = Convert.ToString(leitorRegistros["QUESTAO_ENUNCIADO"])!;
            string respostaCerta = Convert.ToString(leitorRegistros["QUESTAO_RESPOSTACERTA"])!;

            Materia materia = new MapeadorMateria().ConverterRegistro(leitorRegistros);

            return new Questao(id,materia,enunciado,respostaCerta);
        }
    }
}

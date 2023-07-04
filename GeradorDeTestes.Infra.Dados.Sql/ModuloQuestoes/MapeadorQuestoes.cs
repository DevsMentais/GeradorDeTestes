using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.Infra.Dados.Sql.Compartilhado;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloQuestoes
{
    public class MapeadorQuestoes : MapeadorBase<Questoes>
    {
        public override void ConfigurarParametros(SqlCommand comando, Questoes registro)
        {
            throw new NotImplementedException();
        }

        public override Questoes ConverterRegistro(SqlDataReader leitorRegistros)
        {
            throw new NotImplementedException();
        }
    }
}

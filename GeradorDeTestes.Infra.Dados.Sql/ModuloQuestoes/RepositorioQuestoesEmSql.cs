using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.Infra.Dados.Sql.Compartilhado;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloQuestoes
{
    public class RepositorioQuestoesEmSql : RepositorioEmSqlBase<Questoes, MapeadorQuestoes>,IRepositorioQuestoes
    {
        protected override string sqlInserir => throw new NotImplementedException();

        protected override string sqlEditar => throw new NotImplementedException();

        protected override string sqlExcluir => throw new NotImplementedException();

        protected override string sqlSelecionarTodos => throw new NotImplementedException();

        protected override string sqlSelecionarPorId => throw new NotImplementedException();

        public void Inserir(Questoes novoRegistro)
        {
            throw new NotImplementedException();
        }

        public void Editar(int id, Questoes registro)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Questoes registroSelecionado)
        {
            throw new NotImplementedException();
        }

        public Questoes SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Questoes> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}

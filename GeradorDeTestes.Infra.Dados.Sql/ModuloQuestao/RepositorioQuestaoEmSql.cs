using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.Infra.Dados.Sql.Compartilhado;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloQuestoes
{
    public class RepositorioQuestaoEmSql : RepositorioEmSqlBase<Questao, MapeadorQuestao>,IRepositorioQuestao
    {
        protected override string sqlInserir => throw new NotImplementedException();

        protected override string sqlEditar => throw new NotImplementedException();

        protected override string sqlExcluir => throw new NotImplementedException();

        protected override string sqlSelecionarTodos => throw new NotImplementedException();

        protected override string sqlSelecionarPorId => throw new NotImplementedException();

        public void Inserir(Questao novoRegistro)
        {
            throw new NotImplementedException();
        }

        public void Editar(int id, Questao registro)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Questao registroSelecionado)
        {
            throw new NotImplementedException();
        }

        public Questao SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Questao> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}

using GeradorDeTestes.Dominio.Compartilhado;
using GeradorDeTestes.Dominio.ModuloQuestao;

namespace GeradorDeTestes.Dominio.ModuloQuestoes
{
    public interface IRepositorioQuestao : IRepositorioBase<Questao>
    {
        void Inserir(Questao questao, List<Alternativa> alternativasAdicionadas);

        void Editar(int id, Questao questao, List<Alternativa> alternativasMarcadas, List<Alternativa> alternativasDesmarcadas);
    }
}

using GeradorDeTestes.Dominio.Compartilhado;

namespace GeradorDeTestes.Dominio.ModuloMateria
{
    public interface IRepositorioMateria : IRepositorioBase<Materia>
    {
        public void CarregarMateriasDisciplina(Materia materia);
    }
}

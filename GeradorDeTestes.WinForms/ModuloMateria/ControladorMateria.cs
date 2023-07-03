using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.WinForms.Compartilhado;

namespace GeradorDeTestes.WinForms.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        public override string ToolTipInserir => "Inserir Matéria";

        public override string ToolTipEditar => "Editar Matéria";

        public override string ToolTipExcluir => "Excluir Matéria";

        public override void Inserir()
        {
            TelaMateriaForm telaMateriaForm = new TelaMateriaForm();
            Materia
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void ApresentarMensagem(string mensagem, string titulo)
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }

        public override string ObterTipoCadastro()
        {
            throw new NotImplementedException();
        }
    }
}

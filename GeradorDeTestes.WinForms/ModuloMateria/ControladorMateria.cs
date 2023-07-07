using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.WinForms.Compartilhado;

namespace GeradorDeTestes.WinForms.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private IRepositorioDisciplina repositorioDisciplina;
        private IRepositorioMateria repositorioMateria;
        private TabelaMateriaControl tabelaMateria;

        public ControladorMateria(IRepositorioDisciplina repositorioDisciplina, IRepositorioMateria repositorioMateria)
        {
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioMateria = repositorioMateria;
        }

        public override string ToolTipInserir => "Inserir Matéria";

        public override string ToolTipEditar => "Editar Matéria";

        public override string ToolTipExcluir => "Excluir Matéria";

        public override bool DuplicarHabilitado => false;

        public override bool SalvarHabilitado => false;

        public override bool VisualizarHabilitado => false;


        public override void ApresentarMensagem(string mensagem, string titulo)
        {
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public override void Inserir()
        {
            TelaMateriaForm telaMateriaForm = new TelaMateriaForm(repositorioDisciplina.SelecionarTodos(), repositorioMateria.SelecionarTodos());

            DialogResult opcaoEscolhida = telaMateriaForm.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Materia materia = telaMateriaForm.ObterMateria();

                repositorioMateria.CarregarMateriasDisciplina(materia);

                repositorioMateria.Inserir(materia);
            }

            CarregarMaterias();
        }

        public override void Editar()
        {
            TelaMateriaForm telaMateriaForm = new TelaMateriaForm(repositorioDisciplina.SelecionarTodos(), repositorioMateria.SelecionarTodos());

            Materia materiaSelecionada = ObterMateriaSelecionada();

            telaMateriaForm.ConfigurarTela(materiaSelecionada);

            DialogResult opcaoEscolhida = telaMateriaForm.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Materia materia = telaMateriaForm.ObterMateria();

                repositorioMateria.Editar(materia.id, materia);
            }

            CarregarMaterias();
        }
        
        public override void Excluir()
        {
            Materia materiaSelecionada = ObterMateriaSelecionada();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a matéria {materiaSelecionada.Nome}?", "Exclusão de Matérias",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(opcaoEscolhida == DialogResult.OK )
            {
                try
                {
                    repositorioMateria.Excluir(materiaSelecionada);
                }
                catch (Microsoft.Data.SqlClient.SqlException)
                {
                    ApresentarMensagem("Não é possível excluir a materia pois ela possui uma questão!", "Exclusão de Materia");
                }
            }

            CarregarMaterias();
        }

        public override UserControl ObterListagem()
        {
            if(tabelaMateria == null)
                tabelaMateria = new TabelaMateriaControl();

            CarregarMaterias();

            return tabelaMateria;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Matérias";
        }

        private void CarregarMaterias()
        {
            List<Materia> materias = repositorioMateria.SelecionarTodos();

            tabelaMateria.AtualizarRegistros(materias);
        }

        private Materia ObterMateriaSelecionada()
        {
            int id = tabelaMateria.ObterIdSelecionado();

            return repositorioMateria.SelecionarPorId(id); 
        }

    }
}

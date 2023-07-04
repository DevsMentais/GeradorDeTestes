using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.WinForms.Compartilhado;

namespace GeradorDeTestes.WinForms.ModuloDisciplina
{
    public partial class TelaVisualizarMateriasForm : Form
    {
        public TelaVisualizarMateriasForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public void AtualizarLista(List<Materia> materias)
        {
            listMaterias.Items.Clear();

            foreach (Materia materia in materias)
            {
                listMaterias.Items.Add("  ★ " + materia);
            }
        }

        public void CarregarLista(List<Materia> materias)
        {
            AtualizarLista(materias);
        }

        public void CarregarLabel(Disciplina disciplina)
        {
            lblDisciplina.Text = disciplina.Nome;
        }
    }
}

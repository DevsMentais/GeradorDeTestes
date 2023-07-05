using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.WinForms.Compartilhado;

namespace GeradorDeTestes.WinForms.ModuloMateria
{
    public partial class TelaQuestaoForm : Form
    {
        private List<Materia> materias;

        public TelaQuestaoForm(List<Disciplina> disciplinas, List<Materia> materias)
        {
            this.materias = materias;

            InitializeComponent();
            this.ConfigurarDialog();

            CarregarDisciplinas(disciplinas);
        }

        private void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cbDisciplina.Items.Clear();

            foreach (Disciplina disciplina in disciplinas)
            {
                cbDisciplina.Items.Add(disciplina);
            }
        }

        public Materia ObterMateria()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;
            Disciplina disciplina = (Disciplina)cbDisciplina.SelectedItem;
            int serie = 0;

            if (rdbPrimeiro.Checked)
            {
                serie = 1;
            }
            if (rdbSegundo.Checked)
            {
                serie = 2;
            }

            return new Materia(id, nome, disciplina, serie);
        }

        public void ConfigurarTela(Materia materiaSelecionada)
        {
            txtId.Text = materiaSelecionada.id.ToString();
            txtNome.Text = materiaSelecionada.Nome;
            cbDisciplina.SelectedItem = materiaSelecionada.Disciplina;

            if (materiaSelecionada.Serie == 1)
                rdbPrimeiro.Checked = true;
            if (materiaSelecionada.Serie == 2)
                rdbSegundo.Checked = true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Materia materia = ObterMateria();

            ValidarErros(materia);
        }

        private void ValidarErros(Materia materia)
        {
            if (materia == null) return;

            string[] erros = materia.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

            foreach (Materia d in materias)
            {
                if (materia.Nome == d.Nome && txtId.Text == "0")
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape("O nome ja esta em uso");

                    DialogResult = DialogResult.None;
                }
            }
        }
    }
}
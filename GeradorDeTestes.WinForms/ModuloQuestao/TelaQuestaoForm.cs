using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.WinForms.Compartilhado;

namespace GeradorDeTestes.WinForms.ModuloQuestoes
{
    public partial class TelaQuestaoForm : Form
    {
        public TelaQuestaoForm(List<Materia> materias)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarMaterias(materias);
        }

        public void CarregarMaterias(List<Materia> materias)
        {
            cbMateria.Items.Clear();

            foreach (Materia materia in materias)
            {
                cbMateria.Items.Add(materia);
            }
        }

        public Questao ObterQuestao()
        {
            int id = int.Parse(txtId.Text);
            string enunciado = txtEnunciado.Text;
            Materia materia = (Materia)cbMateria.SelectedItem;
            string repostaCerta = chListAlternativas.CheckedItems[0].ToString()!;

            List<string> alternativas = new List<string>();

            foreach(string Item in chListAlternativas.Items)
            {
                alternativas.Add(Item);
            }

            Questao questao = new Questao(id,materia, enunciado, repostaCerta);

            return questao;
        }

        public void ConfigurarTela(Questao questao)
        {
            txtId.Text = questao.id.ToString();
            txtEnunciado.Text = questao.Enunciado;
            cbMateria.SelectedItem = questao.Materia.ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string resposta = txtResposta.Text;

            chListAlternativas.Items.Add(resposta);
        }
    }
}

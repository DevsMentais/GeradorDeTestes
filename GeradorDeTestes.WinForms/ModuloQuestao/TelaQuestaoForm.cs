using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.WinForms.Compartilhado;

namespace GeradorDeTestes.WinForms.ModuloQuestoes
{
    public partial class TelaQuestaoForm : Form
    {
        public TelaQuestaoForm(List <Materia> materias)
        {
            InitializeComponent();
            this.ConfigurarDialog();

            CarregarMaterias(materias);
        }

        public void  CarregarMaterias( List <Materia> materias )
        {
            cbMateria.Items.Clear();

            foreach(Materia materia in materias)
            {
                cbMateria.Items.Add(materia);
            }
        }

        public Questao ObterQuestao()
        {
            int id  = int.Parse(txtId.Text);
            string enunciado = txtEnunciado.Text;
            Materia materia = (Materia)cbMateria.SelectedItem;
            string repostaCerta = txtResposta.Text;

            List <string> alternativas = new List<string>();

            Questao questao = new Questao(materia,enunciado,repostaCerta,alternativas);

            return questao;
            
        }

        public void ConfigurarTela(Questao questao) 
        {
           txtId.Text = questao.id.ToString();
           txtEnunciado.Text = questao.Enunciado;
           cbMateria.SelectedItem = questao.Materia.ToString();
        }
    }
}

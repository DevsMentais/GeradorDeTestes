using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloTestes;
using GeradorDeTestes.WinForms.Compartilhado;

namespace GeradorDeTestes.WinForms.ModuloTestes
{
    public partial class TabelaTesteControl : UserControl
    {
        public TabelaTesteControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "titulo",
                    HeaderText = "Titulo"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "disciplina",
                    HeaderText = "Disciplina"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "materia",
                    HeaderText = "Materia"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "quantidade",
                    HeaderText = "Quantidade de Questoes"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "provaRecuperacao",
                    HeaderText = "Prova de Recuperação"
                }
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Teste> testes)
        {
            grid.Rows.Clear();

            foreach (Teste teste in testes)
            {
                grid.Rows.Add(teste.id, teste.Titulo, teste.Disciplina, teste.Materia, teste.QuantidadeQuestoes, teste.ProvaRecuperacao);
            }
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {testes.Count} teste(s)");
        }

        public int ObterIdSelecionado()
        {
            int id = 0;

            try
            {
                id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
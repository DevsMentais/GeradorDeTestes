using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.Dominio.ModuloTestes;
using GeradorDeTestes.WinForms.Compartilhado;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Document = iTextSharp.text.Document;

namespace GeradorDeTestes.WinForms.ModuloTestes
{
    public partial class TelaGerarPdfForm : Form
    {
        private Teste testeSelecionado;
        private IRepositorioQuestao repositorioQuestao;

        public TelaGerarPdfForm(Teste testeSelecionado, IRepositorioQuestao repositorioQuestao)
        {
            this.repositorioQuestao = repositorioQuestao;
            InitializeComponent();
            this.ConfigurarDialog();
            this.testeSelecionado = testeSelecionado;
        }

        private string DefinirNomeArquivo()
        {
            if (rdbQuestao.Checked)
                return $"{testeSelecionado.Titulo} - Questões";

            else return $"{testeSelecionado.Titulo} - Gabarito";
        }

        private void btnDiretorio_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtDiretorio.Text = fbd.SelectedPath;
            }

            DialogResult = DialogResult.None;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                EscreverPdf();
                MessageBox.Show($"PDF gerado com sucesso! Confira no caminho: \n{txtDiretorio.Text}");
            }
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(txtDiretorio.Text))
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Escolha um diretório para guardar seu PDF");
                DialogResult = DialogResult.None;
                return false;
            }

            if (!rdbQuestao.Checked && !rdbGabarito.Checked)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Escolha qual opção de PDF à ser gerado");
                DialogResult = DialogResult.None;
                return false;
            }

            return true;
        }

        private void EscreverPdf()
        {
            string nomePdf = DefinirNomeArquivo();

            string caminho = Path.Combine(txtDiretorio.Text, nomePdf + ".pdf");

            Document doc = new Document(PageSize.A4, 20, 20, 10, 10);
            FileStream fs = new FileStream(caminho, FileMode.Create, FileAccess.Write, FileShare.None);

            PdfWriter writer = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            BaseColor corPadrao = BaseColor.BLACK;
            BaseColor corGabarito = new BaseColor(34, 139, 34);

            iTextSharp.text.Font fonteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16, corPadrao);
            iTextSharp.text.Font fonteInfo = FontFactory.GetFont(FontFactory.HELVETICA, 13, corPadrao);
            iTextSharp.text.Font fonteQuestao = FontFactory.GetFont(FontFactory.HELVETICA, 12, corPadrao);
            iTextSharp.text.Font fonteGabarito = FontFactory.GetFont(FontFactory.HELVETICA, 12, corGabarito);

            Paragraph data = new Paragraph(string.Format($"Data: {DateTime.Today.ToString("dd/MM/yyyy")}"), fonteInfo);
            doc.Add(data);

            Paragraph disciplina = new Paragraph(string.Format($"Disciplina: {testeSelecionado.Disciplina}"), fonteInfo);
            doc.Add(disciplina);

            Paragraph materia = new Paragraph(string.Format($"Matéria: {testeSelecionado.Materia}, {testeSelecionado.Materia.Serie}"), fonteInfo);
            doc.Add(materia);

            if (testeSelecionado.ProvaRecuperacao)
            {
                Paragraph recuperacao = new Paragraph(string.Format($"Prova de recuperação"), fonteInfo);
                doc.Add(recuperacao);
            }

            doc.Add(new Paragraph(" "));

            Paragraph titulo = new Paragraph(string.Format($"{testeSelecionado.Titulo.ToUpper()}"), fonteTitulo);
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);

            doc.Add(new Paragraph(" "));

            int numeroQuestao = 1;

            testeSelecionado.ListQuestoes.ForEach(q =>
            {
                char letra = 'A';
                repositorioQuestao.CarregarAlternativas(q);

                Paragraph numQuestao = new Paragraph($"Questão {numeroQuestao}:", fonteQuestao);
                numQuestao.FirstLineIndent = 20f;
                numQuestao.SpacingAfter = 5f;
                doc.Add(numQuestao);

                Paragraph questao = new Paragraph($"{numeroQuestao}. {q}", fonteQuestao);
                questao.FirstLineIndent = 40f; 
                doc.Add(questao);
                doc.Add(new Paragraph(" "));

                q.ListAlternativas.ForEach(a =>
                {
                    Paragraph alternativa = new Paragraph(string.Format($"{letra}) {a}"), fonteQuestao);
                    alternativa.FirstLineIndent = 60f;
                    alternativa.SpacingBefore = 5f;
                    alternativa.SpacingAfter = 2f;
                    doc.Add(alternativa);
                    letra++;
                });

                if (rdbGabarito.Checked)
                {
                    Paragraph respostaCerta = new Paragraph(string.Format($"Resposta Certa: {q.RespostaCerta}"), fonteGabarito);
                    respostaCerta.FirstLineIndent = 40f; 
                    respostaCerta.SpacingBefore = 10f;
                    respostaCerta.SpacingAfter = 5f;
                    doc.Add(respostaCerta);
                }

                doc.Add(new Paragraph(" ")); 

                numeroQuestao++;
            });

            doc.Close();
        }


    }
}

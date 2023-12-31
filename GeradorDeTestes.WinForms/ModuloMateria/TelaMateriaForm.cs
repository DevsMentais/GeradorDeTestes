﻿using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.WinForms.Compartilhado;

namespace GeradorDeTestes.WinForms.ModuloMateria
{
    public partial class TelaMateriaForm : Form
    {
        private List<Materia> materias;

        public TelaMateriaForm(List<Disciplina> disciplinas, List<Materia> materias)
        {
            this.materias = materias;

            InitializeComponent();
            this.ConfigurarDialog();

            CarregarDisciplinas(disciplinas);
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
            cbDisciplina.Text = materiaSelecionada.Disciplina.ToString();

            if (materiaSelecionada.Serie == 1)
                rdbPrimeiro.Checked = true;
            if (materiaSelecionada.Serie == 2)
                rdbSegundo.Checked = true;
        }

        private void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cbDisciplina.Items.Clear();

            foreach (Disciplina disciplina in disciplinas)
            {
                cbDisciplina.Items.Add(disciplina);
            }
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
                if (materia.Nome.ToUpper() == d.Nome.ToUpper() && materia.id != d.id)
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape("O nome já esta em uso");

                    DialogResult = DialogResult.None;
                }
            }
        }
    }
}
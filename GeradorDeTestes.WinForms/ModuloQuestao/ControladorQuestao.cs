﻿using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.Dominio.ModuloTestes;
using GeradorDeTestes.WinForms.Compartilhado;

namespace GeradorDeTestes.WinForms.ModuloQuestoes
{
    public class ControladorQuestao : ControladorBase
    {
        private IRepositorioQuestao repositorioQuestao;
        private TabelaQuestaoControl tabelaQuestao;
        private IRepositorioMateria repositorioMateria;
        private IRepositorioTeste repositorioTeste;


        public ControladorQuestao(IRepositorioQuestao repositorioQuestao, IRepositorioMateria repositorioMateria, IRepositorioTeste repositorioTeste)
        {
            this.repositorioQuestao = repositorioQuestao;
            this.repositorioMateria = repositorioMateria;
            this.repositorioTeste = repositorioTeste;
        }

        public override string ToolTipInserir => "Inserir Nova Questão";

        public override string ToolTipEditar => "Editar Questão Existente";

        public override string ToolTipExcluir => "Excluir Questão";

        public override bool DuplicarHabilitado => false;

        public override bool SalvarHabilitado => false;

        public override bool VisualizarHabilitado => false;

        public override void ApresentarMensagem(string mensagem, string titulo)
        {
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public override void Inserir()
        {
            TelaQuestaoForm telaQuestaoForm = new TelaQuestaoForm(repositorioMateria.SelecionarTodos(), repositorioQuestao.SelecionarTodos());

            DialogResult opcaoEscolhida = telaQuestaoForm.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Questao questao = telaQuestaoForm.ObterQuestao();

                repositorioQuestao.Inserir(questao, questao.ListAlternativas);
            }

            CarregarQuestoes();
        }

        public override void Editar()
        {
            TelaQuestaoForm telaQuestaoForm = new TelaQuestaoForm(repositorioMateria.SelecionarTodos(), repositorioQuestao.SelecionarTodos());

            Questao questaoSelecionada = ObterQuestaoSelecionada();

            if (questaoSelecionada == null)
            {
                ApresentarMensagem("Selecione uma questao primeiro!", "Edição de Questoes");
                return;
            }

            telaQuestaoForm.ConfigurarTela(questaoSelecionada);

            DialogResult opcaoEscolhida = telaQuestaoForm.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Questao questao = telaQuestaoForm.ObterQuestao();

                List<Alternativa> alternativasMarcadas = telaQuestaoForm.ObterAlternativasDaLista();

                List<Alternativa> alternativasDesmarcadas = telaQuestaoForm.ObterAlternativasDesmarcadas();

                repositorioQuestao.Editar(questao.id, questao, alternativasMarcadas);

            }

            CarregarQuestoes();
        }

        public override void Excluir()
        {
            Questao questaoSelecionada = ObterQuestaoSelecionada();

            if (questaoSelecionada == null)
            {
                ApresentarMensagem("Selecione uma questao primeiro!", "Exclusão de Questoes");
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a questão {questaoSelecionada.id}?", "Exclusão de Questões",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                try
                {
                    repositorioQuestao.Excluir(questaoSelecionada, repositorioTeste.SelecionarTodos());
                }
                catch (Microsoft.Data.SqlClient.SqlException) 
                {
                    ApresentarMensagem("Não foi possível excluir a questão, ela possui um teste!", "Exclusão de Questões");
                }
            }

            CarregarQuestoes();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaQuestao == null)

                tabelaQuestao = new TabelaQuestaoControl();

            CarregarQuestoes();

            return tabelaQuestao;
        }

        public override string ObterTipoCadastro()
        {
            return "cadastro de questoes";
        }

        private void CarregarQuestoes()
        {
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            tabelaQuestao.AtualizarRegistros(questoes);
        }

        private Questao ObterQuestaoSelecionada()
        {
            int id = tabelaQuestao.ObterIdSelecionado();

            return repositorioQuestao.SelecionarPorId(id);
        }

    }
}

﻿using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.Dominio.ModuloTestes;
using GeradorDeTestes.WinForms.Compartilhado;
using GeradorDeTestes.WinForms.ModuloDisciplina;
using GeradorDeTestes.WinForms.ModuloQuestoes;
using static System.Net.Mime.MediaTypeNames;

namespace GeradorDeTestes.WinForms.ModuloTestes
{
    public class ControladorTeste : ControladorBase
    {
        private IRepositorioTeste repositorioTeste;
        private IRepositorioDisciplina repositorioDisciplina;
        private IRepositorioMateria repositorioMateria;
        private IRepositorioQuestao repositorioQuestao;
        private TabelaTesteControl tabelaTeste;

        public ControladorTeste(IRepositorioTeste repositorioTeste, IRepositorioDisciplina repositorioDisciplina, IRepositorioMateria repositorioMateria, IRepositorioQuestao repositorioQuestao)
        {
            this.repositorioTeste = repositorioTeste;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioMateria = repositorioMateria;
            this.repositorioQuestao = repositorioQuestao;
        }

        public override string ToolTipInserir => "Inserir Novo Teste";

        public override string ToolTipEditar => "Editar Teste Existente";

        public override string ToolTipExcluir => "Excluir Teste Existente";

        public override string ToolTipVisualizar => "Visualizar Questões do Teste";

        public override string ToolTipSalvar => "Salvar Teste em PDF";

        public override string ToolTipDuplicar => "Duplicar Teste";

        public override bool EditarHabilitado => false;


        public override void ApresentarMensagem(string mensagem, string titulo)
        {
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public override void Inserir()
        {
            TelaTesteForm telaTestes = new TelaTesteForm(repositorioMateria.SelecionarTodos(), repositorioDisciplina.SelecionarTodos(),
                repositorioQuestao.SelecionarTodos(), repositorioTeste.SelecionarTodos(), repositorioMateria);

            DialogResult opcaoEscolhida = telaTestes.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Teste teste = telaTestes.ObterTeste();

                repositorioTeste.Inserir(teste, telaTestes.ObterQuestoesSorteadas());
            }
            CarregarTestes();
        }

        public override void Editar()
        {
            Teste testeSelecionado = ObterTesteSelecionado();

            if (testeSelecionado == null)
            {
                MessageBox.Show("Selecione um teste primeiro", "Edição de Testes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            TelaTesteForm telaTestes = new TelaTesteForm(repositorioMateria.SelecionarTodos(), repositorioDisciplina.SelecionarTodos(), 
                repositorioQuestao.SelecionarTodos(), repositorioTeste.SelecionarTodos(), repositorioMateria);

            telaTestes.Text = "Editar teste existente";

            telaTestes.ConfigurarTela(testeSelecionado);

            DialogResult opcaoEscolhida = telaTestes.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Teste teste = telaTestes.ObterTeste();

                repositorioTeste.Editar(teste.id, teste);
            }

            CarregarTestes();
        }

        public override void Excluir()
        {
            Teste testeSelecionado = ObterTesteSelecionado();

            if (testeSelecionado == null)
            {
                ApresentarMensagem("Selecione um teste primeiro!", "Exclusão de Testes");
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir um teste?", "Exclusão de Testes",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTeste.Excluir(testeSelecionado);
            }

            CarregarTestes();
        }

        public override void Visualizar()
        {
            Teste teste = ObterTesteSelecionado();

            TelaVisualizarTesteForm telaListagem = new TelaVisualizarTesteForm();

            if (teste == null)
            {
                ApresentarMensagem("Selecione um teste primeiro!", "Listagem de teste");
                return;
            }

            telaListagem.CarregarLabel(teste);

            telaListagem.CarregarLista(teste.ListQuestoes);

            telaListagem.ShowDialog();
        }

        public override void Duplicar()
        {
            Teste testeSelecionado = ObterTesteSelecionado();

            if (testeSelecionado == null)
            {
                ApresentarMensagem("Selecione um teste primeiro!", "Duplicagem de teste");
                return;
            }

            TelaTesteForm telaTeste = new TelaTesteForm(repositorioMateria.SelecionarTodos(), repositorioDisciplina.SelecionarTodos(),
                repositorioQuestao.SelecionarTodos(), repositorioTeste.SelecionarTodos(), repositorioMateria);

            telaTeste.Text = "Duplicar teste existente";

            telaTeste.ConfigurarTela(testeSelecionado);

            DialogResult opcaoEscolhida = telaTeste.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Teste teste = telaTeste.ObterTeste();
                repositorioTeste.Inserir(teste);
            }

            CarregarTestes();
        }

        public override void Salvar()
        {
            Teste testeSelecionado = ObterTesteSelecionado();

            if (testeSelecionado == null)
            {
                ApresentarMensagem("Selecione um teste primeiro!", "Salvar teste em PDF");
                return;
            }

            TelaGerarPdfForm telaEscolha = new TelaGerarPdfForm(testeSelecionado, repositorioQuestao);
            telaEscolha.Text = $"Gerar PDF do {testeSelecionado.Titulo}";

            telaEscolha.ShowDialog();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTeste == null)
                tabelaTeste = new TabelaTesteControl();

            CarregarTestes();

            return tabelaTeste;
        }

        public override string ObterTipoCadastro()
        {
            return "Registro de Testes";
        }

        private void CarregarTestes()
        {
            List<Teste> listaTestes = repositorioTeste.SelecionarTodos();

            tabelaTeste.AtualizarRegistros(listaTestes);
        }

        private Teste ObterTesteSelecionado()
        {
            int id = tabelaTeste.ObterIdSelecionado();

            return repositorioTeste.SelecionarPorId(id);
        }


    }
}

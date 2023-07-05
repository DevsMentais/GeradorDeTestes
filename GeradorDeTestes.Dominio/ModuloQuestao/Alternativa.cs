using GeradorDeTestes.Dominio.Compartilhado;
using GeradorDeTestes.Dominio.ModuloQuestoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloQuestao
{
    public class Alternativa : EntidadeBase<Alternativa>
    {
        public bool Correta { get; set; }
        public char Letra { get; set; }
        public Questao Questao { get; set; }
        public string Resposta { get; set; }

        public Alternativa(bool correta, char letra, Questao questao, string resposta)
        {
            Correta = correta;
            Letra = letra;
            Questao = questao;
            Resposta = resposta;
        }

        public override void AtualizarInformacoes(Alternativa registroAtualizado)
        {
            Correta = registroAtualizado.Correta;
            Letra = registroAtualizado.Letra;
            Questao = registroAtualizado .Questao;
            Resposta = registroAtualizado.Resposta;
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}

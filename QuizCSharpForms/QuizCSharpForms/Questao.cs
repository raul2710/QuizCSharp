using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizCSharpForms
{
    internal class Questao
    {
        public const int qntAlternativas = 4;
        private String tema;
        private String pergunta;
        private string[] alternativas = new string[qntAlternativas];
        private string resposta;

        public Questao() { }

        public Questao(string tema, string pergunta, string[] alternativas, string resposta)
        {
            this.tema = tema;
            this.pergunta = pergunta;
            this.alternativas = alternativas;
            this.resposta = resposta;
        }

        public string Tema { get => tema; set => tema = value; }
        public string Pergunta { get => pergunta; set => pergunta = value; }
        public string[] Alternativas { get => alternativas; set => alternativas = value; }
        public string Resposta { get => resposta; set => resposta = value; }
    }
}

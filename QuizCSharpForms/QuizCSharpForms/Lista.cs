using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizCSharpForms
{
    internal class Lista
    {
        private Nodo primeiro = null; // ponteiro para o primeiro elemento da lista
        public int Quantidade { get; private set; }
        /// <summary>
        /// Método para inserir um valor na lista
        /// </summary>
        /// <param name="anterior">o nodo que será o anterior ao nodo inserido.
        /// Se o novo nodo for o primeiro, passe null</param>
        /// <param name="valor">o valor a ser inserido</param>
        private void InserirNaPosicao(Nodo anterior, Questao questao)
        {
            Nodo novo = new Nodo();
            novo.Dado = questao;
            Quantidade++;
            if (anterior == null) //indica que será o primeiro da lista
            {
                novo.Proximo = primeiro;
                primeiro = novo;
            }
            else
            {
                novo.Proximo = anterior.Proximo;
                anterior.Proximo = novo;
            }
        }
        /// <summary>
        /// Insere um valor no início da lista
        /// </summary>
        /// <param name="valor"></param>
        public void InserirNoInicio(Questao questao)
        {
            InserirNaPosicao(null, questao);
        }
        /// <summary>
        /// Insere um valor no final da lista
        /// </summary>
        /// <param name="valor"></param>
        public void InserirNoFim(Questao questao)
        {
            if (Quantidade == 0)
                InserirNoInicio(questao);

            else
            {
                Nodo aux = primeiro;
                while (aux.Proximo != null)
                    aux = aux.Proximo;
                InserirNaPosicao(aux, questao);
            }
        }
        /// <summary>
        /// Insere em uma posição, iniciando do 0
        /// </summary>
        /// <param name="valor">valor</param>
        /// <param name="posicao">posicao iniciando do 1</param>
        public void InserirNaPosicao(Questao questao, int posicao)
        {
            if (posicao > Quantidade || posicao < 0)
                throw new Exception("Não é possível inserir.");
            if (posicao == 0)
                InserirNoInicio(questao);
            else
            {
                //descobre qual é o nodo anterior ao que será incluído
                Nodo aux = primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;
                InserirNaPosicao(aux, questao);
            }
        }
        /// <summary>
        /// Remove um elemento da lista com base em sua posição, que inicia
        /// do zero
        /// </summary>
        /// <param name="posicao">posição</param>
        public Questao RemoverDaPosicao(int posicao)
        {
            Questao retorno = null;
            if (posicao >= Quantidade || posicao < 0 || Quantidade == 0)
                throw new Exception("Não é possível remover.");
            if (posicao == 0)
            {
                retorno = primeiro.Dado;
                primeiro = primeiro.Proximo;
            }

            else
            {
                //descobre qual é o nodo anterior que será excluido
                Nodo aux = primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;
                retorno = aux.Proximo.Dado;
                aux.Proximo = aux.Proximo.Proximo;
            }
            Quantidade--;
            return retorno;
        }
        /// <summary>
        /// Retorna um vetor com todos os elementos da lista
        /// </summary>
        /// <returns></returns>
        public Questao[] Listar()
        {
            Questao[] resposta = new Questao[Quantidade];
            Nodo aux = primeiro;
            int n = 0;
            while (aux != null)
            {
                resposta[n++] = aux.Dado;
                aux = aux.Proximo;
            }
            return resposta;
        }

        //Retorna a questao na posicao n da lista
        public Questao MostrarPosicao(int posicao)
        {
            Questao resposta = new Questao();
            Nodo aux = primeiro;
            int n = 0;
            while (aux != null && n<=posicao)
            {
                resposta = aux.Dado;
                aux = aux.Proximo;
                n++;
            }
            return resposta;
        }        
    }
}

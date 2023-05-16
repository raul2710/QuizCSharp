using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QuizCSharpForms
{
    public partial class frmModoJogo : Form
    {
        Questao questao = new Questao();
        Lista listaRespostaUser = new Lista();
        Lista listaQuestoes = new Lista();

        int acertos = 0, erradas = 0;
        int nQuestao = 0;
        public frmModoJogo()
        {
            InitializeComponent();
        }
        public frmModoJogo(int qntdQuestao, string tema)
        {
            InitializeComponent();

            //Faz uma primeira configuração
            lblRespUser.Visible = false;
            btnVoltar.Visible = false;
            btnFinalizar.Enabled = false;
            //Cria uma lista de questões aleatórias
            listaQuestoes = SelecionaPorTema(qntdQuestao, tema);
            //Mostra a primeira questão na tela
            MostrarQuestao(nQuestao, listaQuestoes);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lblRespUser.Visible)
            {
                //Garante que o numero da questão não ultrapasse a quantidade de questões selecionadas
                if (nQuestao < listaQuestoes.Quantidade - 1) nQuestao++;
                else nQuestao = listaQuestoes.Quantidade - 1;

                //Armazena a questão na qual está na tela, para pegar a resposta do usuário
                Questao q = new Questao();
                q = listaRespostaUser.MostrarPosicao(nQuestao);

                //Coloca em verde ou vermelho se ele acertou ou nao
                lblRespUser.ForeColor = q.Resposta.Equals(listaQuestoes.MostrarPosicao(nQuestao).Resposta) ? Color.Green : Color.Red;
                lblRespUser.Text = "Sua resposta: " + q.Resposta;

                //Mostra a questão 
                MostrarQuestao(nQuestao, listaQuestoes);
                //Seleciona nos radiosbuttons a alternativa correta
                AlternativaCorreta(listaQuestoes.MostrarPosicao(nQuestao).Resposta);  
            }
            else
            {
                Questao qTela = listaQuestoes.MostrarPosicao(nQuestao);
                string respUser = string.Copy(AlternativaSelecionada());    //Copia a resposta do usuário
                
                //Cria a questão que irá ser salva com a resposta do usuário
                Questao qSave = new Questao(qTela.Tema, qTela.Pergunta, qTela.Alternativas, respUser);
                
                //Faz a soma de acertos e erros das respostas salvas
                if (qTela.Resposta.Equals(qSave.Resposta)) acertos++;
                else erradas++;

                listaRespostaUser.InserirNoFim(qSave);  //Adiciona na fila de respostas do usuário
                LimpaSelecao(); //Limpa a seleção de RadioButtons

                //Se estiver na última questão da lista ao salvar
                if (nQuestao + 1 == listaQuestoes.Quantidade)
                {
                    btnFinalizar.Enabled = true;    //Habilita para finalizar e ir para os resultados
                    btnSalvar.Enabled = false;      //Desabilita o salvamento de questões
                }

                //Mostra a próxima questão
                if (nQuestao < listaQuestoes.Quantidade - 1) nQuestao++;
                else nQuestao = listaQuestoes.Quantidade - 1;
                //Mostra questão na tela
                MostrarQuestao(nQuestao, listaQuestoes);
            }
        }

        //Configura os RadioButton e Labels com a questão
        void MostrarQuestao(int n, Lista listaQuestoes)
        {
            //Armazena a questão numero n e coloca na tela
            questao = listaQuestoes.MostrarPosicao(n); ;
            
            lblTema.Text = questao.Tema;
            lblPergunta.Text = questao.Pergunta;

            rdbAlternativa1.Text = questao.Alternativas[0];
            rdbAlternativa2.Text = questao.Alternativas[1];
            rdbAlternativa3.Text = questao.Alternativas[2];
            rdbAlternativa4.Text = questao.Alternativas[3];
        }

        //Abre o arquivo txt e faz uma seleção aleatória baseada na quantidade
        //de questão escolhida e o tema escolhido
        private Lista SelecionaPorTema (int nQuestoes, string temaEscolhido)
        {   
            Random rand = new Random();
            String line, tema, pergunta, resposta;
            Lista listaQuestoesPorTema = new Lista();
            Lista listaQuestoesAleatorias = new Lista();

            char separador = '|';

            try
            {
                //Passa o nome do arquivo .txt para o construtor StreamReader
                String fileName = "QUIZ.txt";
                StreamReader sr = new StreamReader(fileName);
                //Lê a primeira linha do arquivo
                line = sr.ReadLine();
                //Continua lendo até achar o fim do arquivo
                while (line != null)
                {
                    //Separa o conteudo da linha
                    if (line.Contains("|"))
                    {
                        tema = line.Split(separador)[1].TrimEnd(' ').TrimStart(' ');
                        if (tema.Equals(temaEscolhido))
                        {
                            //Faz o tratamento da string tirando espaços do fim e começo
                            pergunta = line.Split(separador)[0].TrimEnd(' ').TrimStart(' ');
                            resposta = line.Split(separador)[6].TrimEnd(' ').TrimStart(' ');

                            string[] alternativas = new string[4];
                            for (int i = 0; i < 4; i++)
                            {
                                alternativas[i] = line.Split(separador)[i + 2].TrimEnd(' ').TrimStart(' '); ;
                            }

                            //Cria a questao e adiciona a lista
                            Questao questao = new Questao(tema, pergunta, alternativas, resposta);
                            listaQuestoesPorTema.InserirNoFim(questao);
                        }
                    }

                    //Lê a próxima linha
                    line = sr.ReadLine();
                }
                //Fecha o arquivo
                sr.Close();

                //Cria a lista com numero n de questões e todas selecionadas aleatoriamente
                int maxQuestoes = listaQuestoesPorTema.Quantidade;
                for (int i = 0; i < nQuestoes; i++)
                {
                    //Remove da lista por tema e coloca na questoes aleatorias
                    listaQuestoesAleatorias.InserirNoFim(listaQuestoesPorTema.RemoverDaPosicao(rand.Next(0, maxQuestoes-1)));
                    maxQuestoes--;
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine("Error: " + erro.Message);
            }
            finally
            {
                Console.WriteLine("Arquivo carregado com sucesso.");
            }
            return listaQuestoesAleatorias;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //Limpa as selecoes do radioButton
            LimpaSelecao();
            //Garante que o numero de questões não seja inválida, ou seja menor que 0
            if (nQuestao > 0) nQuestao--;
            else nQuestao = 0;

            //Analisa se o label de resposta está disponível para colocar a resposta
            if (lblRespUser.Visible)
            {
                //Armazena a resposta do usuário
                Questao q = new Questao();
                q = listaRespostaUser.MostrarPosicao(nQuestao);

                //Coloca em verde ou vermelho se ele acertou ou nao
                lblRespUser.ForeColor = q.Resposta.Equals(listaQuestoes.MostrarPosicao(nQuestao).Resposta) ? Color.Green : Color.Red;
                lblRespUser.Text = "Sua resposta: " + q.Resposta; //Mostra a resposta do usuario na tela

                //Mostra a questão anterios
                MostrarQuestao(nQuestao, listaQuestoes);
                //Coloca a alternativa correta nos radiobuttons
                AlternativaCorreta(listaQuestoes.MostrarPosicao(nQuestao).Resposta);  
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //Mostra a última questão na tela
            MostrarQuestao(nQuestao, listaQuestoes);
            Questao q = listaRespostaUser.MostrarPosicao(nQuestao);

            //Mostra os acertos e erros em uma messageBox
            MessageBox.Show("Acertos: " + acertos + "\nErradas: " + erradas, "Resultados");

            //Coloca em verde ou vermelho se ele acertou ou nao
            lblRespUser.ForeColor = q.Resposta.Equals(listaQuestoes.MostrarPosicao(nQuestao).Resposta) ? Color.Green : Color.Red;
            lblRespUser.Text = "Sua resposta: " + q.Resposta;   //Mosra a resposta do usuario na tela
            //Mostra a resposta da ultima questao
            AlternativaCorreta(listaQuestoes.MostrarPosicao(nQuestao).Resposta);

            //Configura para o modo de resultado
            lblRespUser.Visible = true;
            btnVoltar.Visible = true;
            btnFinalizar.Visible = false;
            btnSalvar.Enabled = true;
            btnSalvar.Text = "Proximo";
        }

        //Função que retorna alternativa selecionada
        string AlternativaSelecionada()
        {
            //Percorre todos os RadioButtons e devolve o texto que está no rdButton selecionado
            foreach (RadioButton rb in grpAlternativas.Controls)
            {
                if (rb.Checked)
                {
                    return rb.Text;
                }
            }
            return "Nenhuma alternativa selecionada";
        }

        //Função que seleciona a resposta passada por parametro
        void AlternativaCorreta(string alternativa)
        {
            //Percorre todos RadioButtons e seta o que está com a alternativa passada
            foreach (RadioButton rb in grpAlternativas.Controls)
            {
                if (rb.Text.Equals(alternativa))
                {
                    rb.Checked = true;
                }
            }
        }

        //Deixa os botões sem selecionar
        void LimpaSelecao()
        {
            foreach (RadioButton rb in grpAlternativas.Controls) rb.Checked = false;
        }
    }
    
}


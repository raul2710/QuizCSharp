using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizCSharpForms
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //Converte a entrada de string para int e confere se está dentro da faixa de questões
                int qntdQuestoes = Convert.ToInt32(txtNumQuestoes.Text);
                if (TemaEscolhido() != null && qntdQuestoes <= 5 && qntdQuestoes != 0)
                {
                    //Instancia a tela de modo jogo enviando a quantidade e o tema escolhido das questões
                    frmModoJogo f = new frmModoJogo(qntdQuestoes, TemaEscolhido()); 
                    f.ShowDialog(); //Abre o Modo Jogo
                    this.Dispose();
                }
                else lblAlerta.ForeColor = Color.Red;
            }
            catch(Exception error)
            {
                lblAlerta.ForeColor = Color.Red;
                Console.WriteLine(error.Message);
            }
        }

        //Retorna o tema selecionado 
        private string TemaEscolhido()
        {
            string tema = null;
            foreach (RadioButton r in grpTemas.Controls)
            {
                if (r.Checked)
                {
                    return r.Text;
                }
            }
            return tema;
        }
    }
}

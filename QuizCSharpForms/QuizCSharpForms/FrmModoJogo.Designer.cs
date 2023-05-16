namespace QuizCSharpForms
{
    partial class frmModoJogo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbAlternativa1 = new System.Windows.Forms.RadioButton();
            this.rdbAlternativa2 = new System.Windows.Forms.RadioButton();
            this.rdbAlternativa3 = new System.Windows.Forms.RadioButton();
            this.rdbAlternativa4 = new System.Windows.Forms.RadioButton();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblRespUser = new System.Windows.Forms.Label();
            this.grpAlternativas = new System.Windows.Forms.GroupBox();
            this.grpAlternativas.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbAlternativa1
            // 
            this.rdbAlternativa1.AutoSize = true;
            this.rdbAlternativa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAlternativa1.Location = new System.Drawing.Point(14, 19);
            this.rdbAlternativa1.Name = "rdbAlternativa1";
            this.rdbAlternativa1.Size = new System.Drawing.Size(91, 19);
            this.rdbAlternativa1.TabIndex = 0;
            this.rdbAlternativa1.TabStop = true;
            this.rdbAlternativa1.Text = "Alternativa 1";
            this.rdbAlternativa1.UseVisualStyleBackColor = true;
            // 
            // rdbAlternativa2
            // 
            this.rdbAlternativa2.AutoSize = true;
            this.rdbAlternativa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAlternativa2.Location = new System.Drawing.Point(14, 42);
            this.rdbAlternativa2.Name = "rdbAlternativa2";
            this.rdbAlternativa2.Size = new System.Drawing.Size(91, 19);
            this.rdbAlternativa2.TabIndex = 1;
            this.rdbAlternativa2.TabStop = true;
            this.rdbAlternativa2.Text = "Alternativa 2";
            this.rdbAlternativa2.UseVisualStyleBackColor = true;
            // 
            // rdbAlternativa3
            // 
            this.rdbAlternativa3.AutoSize = true;
            this.rdbAlternativa3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAlternativa3.Location = new System.Drawing.Point(14, 65);
            this.rdbAlternativa3.Name = "rdbAlternativa3";
            this.rdbAlternativa3.Size = new System.Drawing.Size(91, 19);
            this.rdbAlternativa3.TabIndex = 2;
            this.rdbAlternativa3.TabStop = true;
            this.rdbAlternativa3.Text = "Alternativa 3";
            this.rdbAlternativa3.UseVisualStyleBackColor = true;
            // 
            // rdbAlternativa4
            // 
            this.rdbAlternativa4.AutoSize = true;
            this.rdbAlternativa4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAlternativa4.Location = new System.Drawing.Point(14, 88);
            this.rdbAlternativa4.Name = "rdbAlternativa4";
            this.rdbAlternativa4.Size = new System.Drawing.Size(91, 19);
            this.rdbAlternativa4.TabIndex = 3;
            this.rdbAlternativa4.TabStop = true;
            this.rdbAlternativa4.Text = "Alternativa 4";
            this.rdbAlternativa4.UseVisualStyleBackColor = true;
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(12, 127);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(57, 15);
            this.lblPergunta.TabIndex = 4;
            this.lblPergunta.Text = "Pergunta";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(12, 301);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(106, 301);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Tag = "btnSalvar";
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(78, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(119, 31);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Quiz C#";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(198, 301);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 8;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.Location = new System.Drawing.Point(12, 99);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(43, 15);
            this.lblTema.TabIndex = 9;
            this.lblTema.Text = "Tema";
            // 
            // lblRespUser
            // 
            this.lblRespUser.AutoSize = true;
            this.lblRespUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespUser.Location = new System.Drawing.Point(12, 271);
            this.lblRespUser.Name = "lblRespUser";
            this.lblRespUser.Size = new System.Drawing.Size(105, 15);
            this.lblRespUser.TabIndex = 10;
            this.lblRespUser.Text = "Resposta Usuário";
            // 
            // grpAlternativas
            // 
            this.grpAlternativas.Controls.Add(this.rdbAlternativa2);
            this.grpAlternativas.Controls.Add(this.rdbAlternativa1);
            this.grpAlternativas.Controls.Add(this.rdbAlternativa3);
            this.grpAlternativas.Controls.Add(this.rdbAlternativa4);
            this.grpAlternativas.Location = new System.Drawing.Point(15, 145);
            this.grpAlternativas.Name = "grpAlternativas";
            this.grpAlternativas.Size = new System.Drawing.Size(258, 123);
            this.grpAlternativas.TabIndex = 11;
            this.grpAlternativas.TabStop = false;
            // 
            // frmModoJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 347);
            this.Controls.Add(this.grpAlternativas);
            this.Controls.Add(this.lblRespUser);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblPergunta);
            this.Name = "frmModoJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModoJogo";
            this.grpAlternativas.ResumeLayout(false);
            this.grpAlternativas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbAlternativa1;
        private System.Windows.Forms.RadioButton rdbAlternativa2;
        private System.Windows.Forms.RadioButton rdbAlternativa3;
        private System.Windows.Forms.RadioButton rdbAlternativa4;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblRespUser;
        private System.Windows.Forms.GroupBox grpAlternativas;
    }
}


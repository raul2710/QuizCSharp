namespace QuizCSharpForms
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTema = new System.Windows.Forms.Label();
            this.grpTemas = new System.Windows.Forms.GroupBox();
            this.rdbTema3 = new System.Windows.Forms.RadioButton();
            this.rdbTema2 = new System.Windows.Forms.RadioButton();
            this.rdbTema1 = new System.Windows.Forms.RadioButton();
            this.txtNumQuestoes = new System.Windows.Forms.TextBox();
            this.lblNumQuestoes = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAlerta = new System.Windows.Forms.Label();
            this.grpTemas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.Location = new System.Drawing.Point(9, 73);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(117, 15);
            this.lblTema.TabIndex = 0;
            this.lblTema.Text = "Selecione um tema:";
            // 
            // grpTemas
            // 
            this.grpTemas.Controls.Add(this.rdbTema3);
            this.grpTemas.Controls.Add(this.rdbTema2);
            this.grpTemas.Controls.Add(this.rdbTema1);
            this.grpTemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTemas.Location = new System.Drawing.Point(12, 91);
            this.grpTemas.Name = "grpTemas";
            this.grpTemas.Size = new System.Drawing.Size(160, 108);
            this.grpTemas.TabIndex = 3;
            this.grpTemas.TabStop = false;
            // 
            // rdbTema3
            // 
            this.rdbTema3.AutoSize = true;
            this.rdbTema3.Location = new System.Drawing.Point(20, 72);
            this.rdbTema3.Name = "rdbTema3";
            this.rdbTema3.Size = new System.Drawing.Size(101, 19);
            this.rdbTema3.TabIndex = 6;
            this.rdbTema3.TabStop = true;
            this.rdbTema3.Text = "MATEMATICA";
            this.rdbTema3.UseVisualStyleBackColor = true;
            // 
            // rdbTema2
            // 
            this.rdbTema2.AutoSize = true;
            this.rdbTema2.Location = new System.Drawing.Point(20, 47);
            this.rdbTema2.Name = "rdbTema2";
            this.rdbTema2.Size = new System.Drawing.Size(71, 19);
            this.rdbTema2.TabIndex = 5;
            this.rdbTema2.TabStop = true;
            this.rdbTema2.Text = "CINEMA";
            this.rdbTema2.UseVisualStyleBackColor = true;
            // 
            // rdbTema1
            // 
            this.rdbTema1.AutoSize = true;
            this.rdbTema1.Location = new System.Drawing.Point(20, 22);
            this.rdbTema1.Name = "rdbTema1";
            this.rdbTema1.Size = new System.Drawing.Size(80, 19);
            this.rdbTema1.TabIndex = 4;
            this.rdbTema1.TabStop = true;
            this.rdbTema1.Text = "FUTEBOL";
            this.rdbTema1.UseVisualStyleBackColor = true;
            // 
            // txtNumQuestoes
            // 
            this.txtNumQuestoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumQuestoes.Location = new System.Drawing.Point(12, 233);
            this.txtNumQuestoes.Name = "txtNumQuestoes";
            this.txtNumQuestoes.Size = new System.Drawing.Size(160, 21);
            this.txtNumQuestoes.TabIndex = 4;
            this.txtNumQuestoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNumQuestoes
            // 
            this.lblNumQuestoes.AutoSize = true;
            this.lblNumQuestoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumQuestoes.Location = new System.Drawing.Point(9, 215);
            this.lblNumQuestoes.Name = "lblNumQuestoes";
            this.lblNumQuestoes.Size = new System.Drawing.Size(163, 15);
            this.lblNumQuestoes.TabIndex = 5;
            this.lblNumQuestoes.Text = "Insira o número de questões";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 288);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(160, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(26, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(119, 31);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Quiz C#";
            // 
            // lblAlerta
            // 
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.Location = new System.Drawing.Point(12, 257);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(154, 13);
            this.lblAlerta.TabIndex = 8;
            this.lblAlerta.Text = "Escolha um número entre 1 e 5";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 323);
            this.Controls.Add(this.lblAlerta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblNumQuestoes);
            this.Controls.Add(this.txtNumQuestoes);
            this.Controls.Add(this.grpTemas);
            this.Controls.Add(this.lblTema);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.grpTemas.ResumeLayout(false);
            this.grpTemas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.GroupBox grpTemas;
        private System.Windows.Forms.TextBox txtNumQuestoes;
        private System.Windows.Forms.Label lblNumQuestoes;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAlerta;
        private System.Windows.Forms.RadioButton rdbTema3;
        private System.Windows.Forms.RadioButton rdbTema2;
        private System.Windows.Forms.RadioButton rdbTema1;
    }
}
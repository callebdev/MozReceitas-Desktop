namespace MozReceitas_App
{
    partial class FormPrincipal
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnMudarSenha = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.btnNovaReceita = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lstTodasReceitas = new System.Windows.Forms.ListBox();
            this.btnListarTodasReceitas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(632, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(91, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "nome@email.com";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(632, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(119, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Usuario Conectado:";
            // 
            // btnMudarSenha
            // 
            this.btnMudarSenha.Location = new System.Drawing.Point(635, 153);
            this.btnMudarSenha.Name = "btnMudarSenha";
            this.btnMudarSenha.Size = new System.Drawing.Size(116, 36);
            this.btnMudarSenha.TabIndex = 2;
            this.btnMudarSenha.Text = "Mudar Senha";
            this.btnMudarSenha.UseVisualStyleBackColor = true;
            this.btnMudarSenha.Click += new System.EventHandler(this.btnMudarSenha_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btnNovaReceita
            // 
            this.btnNovaReceita.Location = new System.Drawing.Point(635, 65);
            this.btnNovaReceita.Name = "btnNovaReceita";
            this.btnNovaReceita.Size = new System.Drawing.Size(116, 39);
            this.btnNovaReceita.TabIndex = 3;
            this.btnNovaReceita.Text = "Nova Receita";
            this.btnNovaReceita.UseVisualStyleBackColor = true;
            this.btnNovaReceita.Click += new System.EventHandler(this.btnNovaReceita_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(632, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "PAINEL DO USUARIO";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(635, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "TERMINAR SESSAO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstTodasReceitas
            // 
            this.lstTodasReceitas.FormattingEnabled = true;
            this.lstTodasReceitas.Location = new System.Drawing.Point(13, 49);
            this.lstTodasReceitas.Name = "lstTodasReceitas";
            this.lstTodasReceitas.Size = new System.Drawing.Size(613, 316);
            this.lstTodasReceitas.TabIndex = 6;
            // 
            // btnListarTodasReceitas
            // 
            this.btnListarTodasReceitas.Location = new System.Drawing.Point(635, 110);
            this.btnListarTodasReceitas.Name = "btnListarTodasReceitas";
            this.btnListarTodasReceitas.Size = new System.Drawing.Size(116, 37);
            this.btnListarTodasReceitas.TabIndex = 7;
            this.btnListarTodasReceitas.Text = "Actualizar Feed";
            this.btnListarTodasReceitas.UseVisualStyleBackColor = true;
            this.btnListarTodasReceitas.Click += new System.EventHandler(this.btnListarTodasReceitas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "FEED";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 398);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListarTodasReceitas);
            this.Controls.Add(this.lstTodasReceitas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNovaReceita);
            this.Controls.Add(this.btnMudarSenha);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblEmail);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moz Receitas - Menu";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnMudarSenha;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button btnNovaReceita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstTodasReceitas;
        private System.Windows.Forms.Button btnListarTodasReceitas;
        private System.Windows.Forms.Label label2;
    }
}

namespace SistemaBancario
{
    partial class Cadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.GroupCadastrar = new System.Windows.Forms.GroupBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextSobrenome = new System.Windows.Forms.TextBox();
            this.TextConfSenha = new System.Windows.Forms.TextBox();
            this.TextSenha = new System.Windows.Forms.TextBox();
            this.TextCPF = new System.Windows.Forms.TextBox();
            this.TextEmail = new System.Windows.Forms.TextBox();
            this.TextTelefone = new System.Windows.Forms.TextBox();
            this.TextNome = new System.Windows.Forms.TextBox();
            this.BtnCriarConta = new System.Windows.Forms.Button();
            this.TextNome2 = new System.Windows.Forms.PictureBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.GroupCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextNome2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupCadastrar
            // 
            this.GroupCadastrar.BackColor = System.Drawing.SystemColors.ControlText;
            this.GroupCadastrar.Controls.Add(this.imgLogo);
            this.GroupCadastrar.Controls.Add(this.Button1);
            this.GroupCadastrar.Controls.Add(this.TextSobrenome);
            this.GroupCadastrar.Controls.Add(this.TextConfSenha);
            this.GroupCadastrar.Controls.Add(this.TextSenha);
            this.GroupCadastrar.Controls.Add(this.TextCPF);
            this.GroupCadastrar.Controls.Add(this.TextEmail);
            this.GroupCadastrar.Controls.Add(this.TextTelefone);
            this.GroupCadastrar.Controls.Add(this.TextNome);
            this.GroupCadastrar.Controls.Add(this.BtnCriarConta);
            this.GroupCadastrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.GroupCadastrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GroupCadastrar.Location = new System.Drawing.Point(150, 20);
            this.GroupCadastrar.Name = "GroupCadastrar";
            this.GroupCadastrar.Size = new System.Drawing.Size(300, 410);
            this.GroupCadastrar.TabIndex = 28;
            this.GroupCadastrar.TabStop = false;
            this.GroupCadastrar.UseCompatibleTextRendering = true;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Antonio", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button1.Location = new System.Drawing.Point(35, 348);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(110, 38);
            this.Button1.TabIndex = 35;
            this.Button1.Text = "VOLTAR";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // TextSobrenome
            // 
            this.TextSobrenome.Font = new System.Drawing.Font("Antonio", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextSobrenome.Location = new System.Drawing.Point(150, 112);
            this.TextSobrenome.MaxLength = 60;
            this.TextSobrenome.Name = "TextSobrenome";
            this.TextSobrenome.PlaceholderText = "SOBRENOME";
            this.TextSobrenome.Size = new System.Drawing.Size(98, 29);
            this.TextSobrenome.TabIndex = 34;
            this.TextSobrenome.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_2);
            // 
            // TextConfSenha
            // 
            this.TextConfSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextConfSenha.Font = new System.Drawing.Font("Antonio", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextConfSenha.Location = new System.Drawing.Point(48, 287);
            this.TextConfSenha.MaxLength = 30;
            this.TextConfSenha.Name = "TextConfSenha";
            this.TextConfSenha.PlaceholderText = "CONFIRMAR SENHA";
            this.TextConfSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextConfSenha.Size = new System.Drawing.Size(200, 29);
            this.TextConfSenha.TabIndex = 33;
            this.TextConfSenha.UseSystemPasswordChar = true;
            // 
            // TextSenha
            // 
            this.TextSenha.Font = new System.Drawing.Font("Antonio", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextSenha.Location = new System.Drawing.Point(48, 252);
            this.TextSenha.MaxLength = 32;
            this.TextSenha.Name = "TextSenha";
            this.TextSenha.PlaceholderText = "SENHA";
            this.TextSenha.Size = new System.Drawing.Size(200, 29);
            this.TextSenha.TabIndex = 32;
            this.TextSenha.UseSystemPasswordChar = true;
            // 
            // TextCPF
            // 
            this.TextCPF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextCPF.Font = new System.Drawing.Font("Antonio", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextCPF.Location = new System.Drawing.Point(48, 217);
            this.TextCPF.MaxLength = 14;
            this.TextCPF.Name = "TextCPF";
            this.TextCPF.PlaceholderText = "CPF";
            this.TextCPF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextCPF.Size = new System.Drawing.Size(200, 29);
            this.TextCPF.TabIndex = 31;
            // 
            // TextEmail
            // 
            this.TextEmail.Font = new System.Drawing.Font("Antonio", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextEmail.Location = new System.Drawing.Point(48, 182);
            this.TextEmail.MaxLength = 60;
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.PlaceholderText = "EMAIL";
            this.TextEmail.Size = new System.Drawing.Size(200, 29);
            this.TextEmail.TabIndex = 30;
            this.TextEmail.TextChanged += new System.EventHandler(this.TextData_TextChanged);
            // 
            // TextTelefone
            // 
            this.TextTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextTelefone.Font = new System.Drawing.Font("Antonio", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextTelefone.Location = new System.Drawing.Point(48, 147);
            this.TextTelefone.MaxLength = 15;
            this.TextTelefone.Name = "TextTelefone";
            this.TextTelefone.PlaceholderText = "TELEFONE";
            this.TextTelefone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextTelefone.Size = new System.Drawing.Size(200, 29);
            this.TextTelefone.TabIndex = 29;
            // 
            // TextNome
            // 
            this.TextNome.Font = new System.Drawing.Font("Antonio", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextNome.Location = new System.Drawing.Point(48, 112);
            this.TextNome.MaxLength = 60;
            this.TextNome.Name = "TextNome";
            this.TextNome.PlaceholderText = "NOME ";
            this.TextNome.Size = new System.Drawing.Size(98, 29);
            this.TextNome.TabIndex = 28;
            // 
            // BtnCriarConta
            // 
            this.BtnCriarConta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnCriarConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCriarConta.FlatAppearance.BorderSize = 0;
            this.BtnCriarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCriarConta.Font = new System.Drawing.Font("Antonio", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCriarConta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCriarConta.Location = new System.Drawing.Point(150, 348);
            this.BtnCriarConta.Name = "BtnCriarConta";
            this.BtnCriarConta.Size = new System.Drawing.Size(110, 38);
            this.BtnCriarConta.TabIndex = 20;
            this.BtnCriarConta.Text = "CRIAR CONTA";
            this.BtnCriarConta.UseVisualStyleBackColor = false;
            // 
            // TextNome2
            // 
            this.TextNome2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextNome2.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextNome2.ErrorImage = null;
            this.TextNome2.Location = new System.Drawing.Point(49, 22);
            this.TextNome2.Name = "TextNome2";
            this.TextNome2.Size = new System.Drawing.Size(199, 58);
            this.TextNome2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TextNome2.TabIndex = 23;
            this.TextNome2.TabStop = false;
            this.TextNome2.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button2.Font = new System.Drawing.Font("Antonio", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button2.Location = new System.Drawing.Point(100, 187);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(100, 35);
            this.Button2.TabIndex = 19;
            this.Button2.Text = "ENTRAR";
            this.Button2.UseVisualStyleBackColor = false;
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkLabel1.Font = new System.Drawing.Font("Antonio", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LinkLabel1.ForeColor = System.Drawing.Color.Honeydew;
            this.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LinkLabel1.LinkColor = System.Drawing.Color.White;
            this.LinkLabel1.Location = new System.Drawing.Point(88, 236);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(124, 14);
            this.LinkLabel1.TabIndex = 26;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Esqueceu a senha? Clique aqui.";
            this.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Silver;
            // 
            // TextBox3
            // 
            this.TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox3.Font = new System.Drawing.Font("Antonio", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox3.Location = new System.Drawing.Point(50, 217);
            this.TextBox3.MaxLength = 30;
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.PlaceholderText = "SENHA";
            this.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBox3.Size = new System.Drawing.Size(200, 29);
            this.TextBox3.TabIndex = 29;
            this.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox3.UseSystemPasswordChar = true;
            // 
            // TextBox4
            // 
            this.TextBox4.Font = new System.Drawing.Font("Antonio", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox4.Location = new System.Drawing.Point(50, 182);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.PlaceholderText = "CPF";
            this.TextBox4.Size = new System.Drawing.Size(200, 29);
            this.TextBox4.TabIndex = 28;
            this.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgLogo.ErrorImage = null;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(51, 22);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(199, 58);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 36;
            this.imgLogo.TabStop = false;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.GroupCadastrar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco Carreira Única";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupCadastrar.ResumeLayout(false);
            this.GroupCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextNome2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GroupCadastrar;
        private System.Windows.Forms.PictureBox TextNome2;
        private System.Windows.Forms.Button BtnCriarConta;
        private System.Windows.Forms.TextBox TextConfSenha;
        private System.Windows.Forms.TextBox TextSenha;
        private System.Windows.Forms.TextBox TextCPF;
        private System.Windows.Forms.TextBox TextEmail;
        private System.Windows.Forms.TextBox TextTelefone;
        private System.Windows.Forms.TextBox TextNome;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.LinkLabel LinkLabel1;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.TextBox TextBox4;
        private System.Windows.Forms.TextBox TextSobrenome;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.PictureBox imgLogo;
    }
}


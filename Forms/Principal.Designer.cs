
namespace SistemaBancario
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.GroupLogin = new System.Windows.Forms.GroupBox();
            this.LblTermos = new System.Windows.Forms.Label();
            this.LinkEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.ImgLinha = new System.Windows.Forms.PictureBox();
            this.ImgLogo = new System.Windows.Forms.PictureBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.BtnCadastro = new System.Windows.Forms.Button();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.TxtCPF = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.GroupLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupLogin
            // 
            this.GroupLogin.BackColor = System.Drawing.Color.Black;
            this.GroupLogin.Controls.Add(this.LblTermos);
            this.GroupLogin.Controls.Add(this.LinkEsqueceuSenha);
            this.GroupLogin.Controls.Add(this.ImgLinha);
            this.GroupLogin.Controls.Add(this.ImgLogo);
            this.GroupLogin.Controls.Add(this.TxtSenha);
            this.GroupLogin.Controls.Add(this.BtnCadastro);
            this.GroupLogin.Controls.Add(this.BtnEntrar);
            this.GroupLogin.Controls.Add(this.TxtCPF);
            this.GroupLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.GroupLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GroupLogin.Location = new System.Drawing.Point(150, 20);
            this.GroupLogin.Name = "GroupLogin";
            this.GroupLogin.Size = new System.Drawing.Size(300, 410);
            this.GroupLogin.TabIndex = 0;
            this.GroupLogin.TabStop = false;
            // 
            // LblTermos
            // 
            this.LblTermos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LblTermos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTermos.Location = new System.Drawing.Point(1, 361);
            this.LblTermos.Name = "LblTermos";
            this.LblTermos.Size = new System.Drawing.Size(298, 45);
            this.LblTermos.TabIndex = 27;
            this.LblTermos.Text = "O projeto apresentado é apenas para fins educacionais, referente ao treinamento C" +
    "arreira Única, sendo de total proibição a utilização do mesmo.";
            this.LblTermos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LinkEsqueceuSenha
            // 
            this.LinkEsqueceuSenha.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.LinkEsqueceuSenha.AutoSize = true;
            this.LinkEsqueceuSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkEsqueceuSenha.Font = new System.Drawing.Font("Antonio", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LinkEsqueceuSenha.ForeColor = System.Drawing.Color.Honeydew;
            this.LinkEsqueceuSenha.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LinkEsqueceuSenha.LinkColor = System.Drawing.Color.White;
            this.LinkEsqueceuSenha.Location = new System.Drawing.Point(88, 236);
            this.LinkEsqueceuSenha.Name = "LinkEsqueceuSenha";
            this.LinkEsqueceuSenha.Size = new System.Drawing.Size(124, 14);
            this.LinkEsqueceuSenha.TabIndex = 26;
            this.LinkEsqueceuSenha.TabStop = true;
            this.LinkEsqueceuSenha.Text = "Esqueceu a senha? Clique aqui.";
            this.LinkEsqueceuSenha.VisitedLinkColor = System.Drawing.Color.Silver;
            this.LinkEsqueceuSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkEsqueceuSenha_LinkClicked);
            // 
            // ImgLinha
            // 
            this.ImgLinha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImgLinha.ErrorImage = null;
            this.ImgLinha.Image = ((System.Drawing.Image)(resources.GetObject("ImgLinha.Image")));
            this.ImgLinha.Location = new System.Drawing.Point(1, 261);
            this.ImgLinha.Name = "ImgLinha";
            this.ImgLinha.Size = new System.Drawing.Size(298, 36);
            this.ImgLinha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgLinha.TabIndex = 25;
            this.ImgLinha.TabStop = false;
            this.ImgLinha.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // ImgLogo
            // 
            this.ImgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImgLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImgLogo.ErrorImage = null;
            this.ImgLogo.Image = ((System.Drawing.Image)(resources.GetObject("ImgLogo.Image")));
            this.ImgLogo.Location = new System.Drawing.Point(51, 22);
            this.ImgLogo.Name = "ImgLogo";
            this.ImgLogo.Size = new System.Drawing.Size(199, 58);
            this.ImgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgLogo.TabIndex = 23;
            this.ImgLogo.TabStop = false;
            this.ImgLogo.Click += new System.EventHandler(this.ImgLogo_Click);
            // 
            // TxtSenha
            // 
            this.TxtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSenha.Font = new System.Drawing.Font("Antonio", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSenha.Location = new System.Drawing.Point(50, 147);
            this.TxtSenha.MaxLength = 30;
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PlaceholderText = "SENHA";
            this.TxtSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtSenha.Size = new System.Drawing.Size(200, 29);
            this.TxtSenha.TabIndex = 22;
            this.TxtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSenha.UseSystemPasswordChar = true;
            this.TxtSenha.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.BackColor = System.Drawing.Color.DarkRed;
            this.BtnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadastro.FlatAppearance.BorderSize = 0;
            this.BtnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastro.Font = new System.Drawing.Font("Antonio", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastro.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnCadastro.Location = new System.Drawing.Point(63, 303);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(174, 38);
            this.BtnCadastro.TabIndex = 20;
            this.BtnCadastro.Text = "CRIAR CONTA";
            this.BtnCadastro.UseVisualStyleBackColor = false;
            this.BtnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEntrar.FlatAppearance.BorderSize = 0;
            this.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrar.Font = new System.Drawing.Font("Antonio", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEntrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEntrar.Location = new System.Drawing.Point(100, 187);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(100, 35);
            this.BtnEntrar.TabIndex = 19;
            this.BtnEntrar.Text = "ENTRAR";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // TxtCPF
            // 
            this.TxtCPF.Font = new System.Drawing.Font("Antonio", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCPF.Location = new System.Drawing.Point(50, 112);
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.PlaceholderText = "CPF";
            this.TxtCPF.Size = new System.Drawing.Size(200, 29);
            this.TxtCPF.TabIndex = 11;
            this.TxtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCPF.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
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
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.GroupLogin);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco Carreira Única";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupLogin.ResumeLayout(false);
            this.GroupLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupLogin;
        private System.Windows.Forms.TextBox TxtCPF;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Button BtnCadastro;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.PictureBox ImgLogo;
        private System.Windows.Forms.PictureBox ImgLinha;
        private System.Windows.Forms.Label LblTermos;
        private System.Windows.Forms.LinkLabel LinkEsqueceuSenha;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.LinkLabel LinkLabel1;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.TextBox TextBox4;
    }
}


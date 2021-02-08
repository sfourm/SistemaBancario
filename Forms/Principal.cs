using System;
using System.Windows.Forms;
using System.Threading;

namespace SistemaBancario
{
    public partial class Principal : Form
    {
        Thread nt;

        public Principal()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(FormCadastro);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void FormCadastro(object obj)
        {
            Application.Run(new Cadastro());
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImgLogo_Click(object sender, EventArgs e)
        {

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinkEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}

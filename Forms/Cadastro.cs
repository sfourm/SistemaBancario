using System;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SistemaBancario
{
    public partial class Cadastro : Form
    {
        Thread nt;

        public Cadastro()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextData_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(FormLogin);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void FormLogin(object obj)
        {
            Application.Run(new Principal());
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

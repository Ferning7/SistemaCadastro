using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 telaCadastro = new Form1();
            telaCadastro.Show();
            this.Hide();
        }

        private void linkResetSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            txtSenha.PasswordChar = CheckMostrarSenha.Checked ? '\0' : '•';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Sistema telaSistema = new Sistema();
            telaSistema.Show();
            this.Hide();
        }
    }
}

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
    public partial class Sistema : Form
    {

        private string nomeUsuario;
        private Form telaLogin;

        public Sistema(string nome, Form tela)
        {
            InitializeComponent();
            nomeUsuario = nome;
            telaLogin = tela;
        }

        private void Sistema_Load(object sender, EventArgs e)
        {
            NomeUser.Text = $"Bem vindo, {nomeUsuario}!";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Sistema_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}

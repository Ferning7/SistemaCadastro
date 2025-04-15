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

        public Sistema(string nome)
        {
            InitializeComponent();
            nomeUsuario = nome;
        }

        private void Sistema_Load(object sender, EventArgs e)
        {
            NomeUser.Text = "Bem vindo," + nomeUsuario + "!";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

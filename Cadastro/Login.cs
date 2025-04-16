using MySql.Data.MySqlClient;
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
            Cadastro telaCadastro = new Cadastro(this);
            telaCadastro.Show();
            this.Hide();
        }

        private void linkResetSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MudarSenha mudarSenha = new MudarSenha();
            mudarSenha.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            txtSenha.PasswordChar = CheckMostrarSenha.Checked ? '\0' : '•';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtEmail.Text.Equals("") && !txtSenha.Equals(""))
                {
                    Usuarios usuarios = new Usuarios();
                    usuarios.Email = txtEmail.Text;
                    usuarios.Senha = txtSenha.Text;

                    if (Usuarios.ValidarEmail(txtEmail.Text))
                    {
                        if (usuarios.verificarLogin())
                        {
                            MessageBox.Show("Login realizado com sucesso!");
                            
                            string nomeLogado = usuarios.BuscarNome();

                            Sistema sistema = new Sistema(nomeLogado, this);

                            sistema.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Forneça um email válido");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível acessar o sistema" + ex.Message);
            }
        }
    }
}

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
    public partial class MudarSenha : Form
    {
        public MudarSenha()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login telaLogin = new Login();
            telaLogin.Show();
            this.Hide();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            try
            {
                if(!txtEmail.Text.Equals("") && !txtNovaSenha.Equals("") && !txtConfirmSenha.Text.Equals(""))
                {
                    Usuarios usuario = new Usuarios();
                    usuario.Email = txtEmail.Text;
                    usuario.Senha = txtNovaSenha.Text;
                    
                    if (Usuarios.ValidarEmail(txtEmail.Text))
                    {
                        if (!usuario.verificarEmailExistente())
                        {
                            if (txtNovaSenha.Text == txtConfirmSenha.Text)
                            {
                                if (usuario.MudarSenha())
                                {
                                    MessageBox.Show("Senha atualizada");
                                    Login telaLogin = new Login();
                                    this.Hide();
                                    telaLogin.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Senhas não são iguais");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email não existe");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email inválido");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
            }
        }

        private void MudarSenha_Load(object sender, EventArgs e)
        {

        }
    }
}


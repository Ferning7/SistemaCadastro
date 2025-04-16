namespace Cadastro
{
    public partial class Cadastro : Form
    {
        private Form telaCadastro;
        public Cadastro(Form tela)
        {
            InitializeComponent();
            telaCadastro = tela;
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login telaLogin = new Login();
            telaLogin.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !txtCriarSenha.Text.Equals(""))
                {
                    Usuarios usuario = new Usuarios();
                    usuario.Nome = txtNome.Text;
                    usuario.Email = txtEmail.Text;
                    usuario.Senha = txtCriarSenha.Text;

                    if (Usuarios.ValidarEmail(txtEmail.Text))
                    {
                        if(usuario.verificarEmailExistente())
                        {
                            if (usuario.CadastrarUsuario())
                            {
                                MessageBox.Show("Cadastro realizado");
                                Login telaLogin = new Login();
                                this.Hide();
                                telaLogin.Show();
                            }
                            else
                            {
                                MessageBox.Show("Falha ao cadastrar usuário");
                                txtEmail.Clear();
                                txtCriarSenha.Clear();
                                txtNome.Clear();
                            }
                        }
                        else
                        {
                            txtEmail.Clear();
                            txtCriarSenha.Clear();
                            txtNome.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email inválido");
                        txtEmail.Clear();
                        txtCriarSenha.Clear();
                        txtNome.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void checkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {

            txtCriarSenha.PasswordChar = checkMostrarSenha.Checked ? '\0' : '•';
        }
    }
}

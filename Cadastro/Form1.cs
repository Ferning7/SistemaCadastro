namespace Cadastro
{
    public partial class Form1 : Form
    {
        private Form telaCadastro;
        public Form1(Form tela)
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

                    if (Usuarios.verificarEmail(txtEmail.Text))
                    {
                        if (usuario.CadastrarUsuario())
                        {
                            MessageBox.Show("Cadastro realizado");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao cadastrar usuário");
                        }
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

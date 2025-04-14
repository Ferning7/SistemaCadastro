namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                        } else
                        {
                            MessageBox.Show("Falha ao cadastrar usuário");
                        }
                    }
                } else
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
    }
}

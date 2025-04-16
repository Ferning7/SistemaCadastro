namespace Cadastro
{
    partial class Cadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            lblNome = new Label();
            lblEmail = new Label();
            lblNovaSenha = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCriarSenha = new TextBox();
            btnCadastrar = new Button();
            linkLabel1 = new LinkLabel();
            groupBox1 = new GroupBox();
            checkMostrarSenha = new CheckBox();
            lblTitulo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(117, 63);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 25);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(117, 142);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.AutoSize = true;
            lblNovaSenha.Location = new Point(117, 230);
            lblNovaSenha.Margin = new Padding(4, 0, 4, 0);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(101, 25);
            lblNovaSenha.TabIndex = 2;
            lblNovaSenha.Text = "Criar Senha";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(117, 93);
            txtNome.Margin = new Padding(4, 5, 4, 5);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(350, 31);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(117, 172);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(350, 31);
            txtEmail.TabIndex = 2;
            // 
            // txtCriarSenha
            // 
            txtCriarSenha.Location = new Point(117, 260);
            txtCriarSenha.Margin = new Padding(4, 5, 4, 5);
            txtCriarSenha.MaxLength = 8;
            txtCriarSenha.Name = "txtCriarSenha";
            txtCriarSenha.PasswordChar = '•';
            txtCriarSenha.Size = new Size(350, 31);
            txtCriarSenha.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(210, 350);
            btnCadastrar.Margin = new Padding(4, 5, 4, 5);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(157, 57);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(206, 412);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(168, 25);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ja possui Cadastro?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(checkMostrarSenha);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Controls.Add(txtCriarSenha);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(lblNovaSenha);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Location = new Point(80, 88);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(581, 487);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // checkMostrarSenha
            // 
            checkMostrarSenha.AutoSize = true;
            checkMostrarSenha.Location = new Point(121, 308);
            checkMostrarSenha.Margin = new Padding(4, 5, 4, 5);
            checkMostrarSenha.Name = "checkMostrarSenha";
            checkMostrarSenha.Size = new Size(153, 29);
            checkMostrarSenha.TabIndex = 6;
            checkMostrarSenha.Text = "Mostrar Senha";
            checkMostrarSenha.UseVisualStyleBackColor = true;
            checkMostrarSenha.CheckedChanged += checkMostrarSenha_CheckedChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Arial Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(277, 37);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(200, 42);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "CADASTRO";
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 635);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblEmail;
        private Label lblNovaSenha;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCriarSenha;
        private Button btnCadastrar;
        private LinkLabel linkLabel1;
        private GroupBox groupBox1;
        private Label lblTitulo;
        private CheckBox checkMostrarSenha;
    }
}

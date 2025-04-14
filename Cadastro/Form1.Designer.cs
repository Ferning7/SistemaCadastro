namespace Cadastro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblNome = new Label();
            lblEmail = new Label();
            lblNovaSenha = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCriarSenha = new TextBox();
            btnCadastrar = new Button();
            linkLabel1 = new LinkLabel();
            groupBox1 = new GroupBox();
            lblTitulo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(82, 38);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(82, 85);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.AutoSize = true;
            lblNovaSenha.Location = new Point(82, 142);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(67, 15);
            lblNovaSenha.TabIndex = 2;
            lblNovaSenha.Text = "Criar Senha";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(82, 56);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(246, 23);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(82, 103);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(246, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtCriarSenha
            // 
            txtCriarSenha.Location = new Point(82, 160);
            txtCriarSenha.MaxLength = 8;
            txtCriarSenha.Name = "txtCriarSenha";
            txtCriarSenha.Size = new Size(246, 23);
            txtCriarSenha.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(147, 203);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(110, 34);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(148, 240);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(109, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ja possui Cadastro?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Controls.Add(txtCriarSenha);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(lblNovaSenha);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Location = new Point(56, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 292);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(194, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(136, 28);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "CADASTRO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 381);
            Controls.Add(lblTitulo);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
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
    }
}

namespace Cadastro
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            lblEmail = new Label();
            lblSenha = new Label();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            linkResetSenha = new LinkLabel();
            groupBox1 = new GroupBox();
            CheckMostrarSenha = new CheckBox();
            linkCadastrar = new LinkLabel();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(133, 160);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(118, 35);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(75, 36);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            lblEmail.Click += label1_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(72, 88);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(75, 106);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '•';
            txtSenha.Size = new Size(222, 23);
            txtSenha.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(75, 54);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(222, 23);
            txtEmail.TabIndex = 1;
            // 
            // linkResetSenha
            // 
            linkResetSenha.AutoSize = true;
            linkResetSenha.Location = new Point(147, 198);
            linkResetSenha.Name = "linkResetSenha";
            linkResetSenha.Size = new Size(91, 15);
            linkResetSenha.TabIndex = 5;
            linkResetSenha.TabStop = true;
            linkResetSenha.Text = "Esqueci a Senha";
            linkResetSenha.LinkClicked += linkResetSenha_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CheckMostrarSenha);
            groupBox1.Controls.Add(linkCadastrar);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(linkResetSenha);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(lblSenha);
            groupBox1.Location = new Point(64, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(380, 276);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // CheckMostrarSenha
            // 
            CheckMostrarSenha.AutoSize = true;
            CheckMostrarSenha.Location = new Point(75, 135);
            CheckMostrarSenha.Name = "CheckMostrarSenha";
            CheckMostrarSenha.Size = new Size(102, 19);
            CheckMostrarSenha.TabIndex = 4;
            CheckMostrarSenha.Text = "Mostrar Senha";
            CheckMostrarSenha.UseVisualStyleBackColor = true;
            CheckMostrarSenha.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkCadastrar
            // 
            linkCadastrar.AutoSize = true;
            linkCadastrar.Location = new Point(158, 219);
            linkCadastrar.Name = "linkCadastrar";
            linkCadastrar.Size = new Size(70, 15);
            linkCadastrar.TabIndex = 6;
            linkCadastrar.TabStop = true;
            linkCadastrar.Text = "Cadastre-Se";
            linkCadastrar.LinkClicked += linkCadastrar_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 36);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 7;
            label1.Text = "LOG IN";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 381);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblEmail;
        private Label lblSenha;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private LinkLabel linkResetSenha;
        private GroupBox groupBox1;
        private LinkLabel linkCadastrar;
        private CheckBox CheckMostrarSenha;
        private Label label1;
    }
}
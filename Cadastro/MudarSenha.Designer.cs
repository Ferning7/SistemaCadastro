namespace Cadastro
{
    partial class MudarSenha
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
            lblMudarSenha = new Label();
            groupBox1 = new GroupBox();
            lblVEmail = new Label();
            txtEmail = new TextBox();
            linkLogin = new LinkLabel();
            btnConfirmar = new Button();
            lblEmail = new Label();
            txtConfirmSenha = new TextBox();
            txtNovaSenha = new TextBox();
            lblSenha = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMudarSenha
            // 
            lblMudarSenha.AutoSize = true;
            lblMudarSenha.Font = new Font("Arial Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMudarSenha.Location = new Point(230, 62);
            lblMudarSenha.Margin = new Padding(4, 0, 4, 0);
            lblMudarSenha.Name = "lblMudarSenha";
            lblMudarSenha.Size = new Size(299, 42);
            lblMudarSenha.TabIndex = 9;
            lblMudarSenha.Text = "MUDAR A SENHA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblVEmail);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(linkLogin);
            groupBox1.Controls.Add(btnConfirmar);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(txtConfirmSenha);
            groupBox1.Controls.Add(txtNovaSenha);
            groupBox1.Controls.Add(lblSenha);
            groupBox1.Location = new Point(99, 113);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(543, 460);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblVEmail
            // 
            lblVEmail.AutoSize = true;
            lblVEmail.Location = new Point(115, 47);
            lblVEmail.Margin = new Padding(4, 0, 4, 0);
            lblVEmail.Name = "lblVEmail";
            lblVEmail.Size = new Size(54, 25);
            lblVEmail.TabIndex = 5;
            lblVEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(115, 77);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(315, 31);
            txtEmail.TabIndex = 6;
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Location = new Point(249, 370);
            linkLogin.Margin = new Padding(4, 0, 4, 0);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(56, 25);
            linkLogin.TabIndex = 4;
            linkLogin.TabStop = true;
            linkLogin.Text = "Login";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(189, 305);
            btnConfirmar.Margin = new Padding(4, 5, 4, 5);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(169, 58);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(115, 132);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(107, 25);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Nova Senha";
            // 
            // txtConfirmSenha
            // 
            txtConfirmSenha.Location = new Point(115, 239);
            txtConfirmSenha.Margin = new Padding(4, 5, 4, 5);
            txtConfirmSenha.Name = "txtConfirmSenha";
            txtConfirmSenha.Size = new Size(315, 31);
            txtConfirmSenha.TabIndex = 2;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(115, 162);
            txtNovaSenha.Margin = new Padding(4, 5, 4, 5);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(315, 31);
            txtNovaSenha.TabIndex = 1;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(111, 209);
            lblSenha.Margin = new Padding(4, 0, 4, 0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(142, 25);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Confirmar senha";
            // 
            // MudarSenha
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 635);
            Controls.Add(lblMudarSenha);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MudarSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MudarSenha";
            Load += MudarSenha_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMudarSenha;
        private GroupBox groupBox1;
        private LinkLabel linkCadastrar;
        private Button btnConfirmar;
        private LinkLabel linkResetSenha;
        private Label lblEmail;
        private TextBox txtConfirmSenha;
        private TextBox txtNovaSenha;
        private Label lblSenha;
        private LinkLabel linkLogin;
        private Label lblVEmail;
        private TextBox txtEmail;
    }
}
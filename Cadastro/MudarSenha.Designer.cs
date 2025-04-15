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
            lblMudarSenha.Location = new Point(161, 37);
            lblMudarSenha.Name = "lblMudarSenha";
            lblMudarSenha.Size = new Size(203, 28);
            lblMudarSenha.TabIndex = 9;
            lblMudarSenha.Text = "MUDAR A SENHA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLogin);
            groupBox1.Controls.Add(btnConfirmar);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(txtConfirmSenha);
            groupBox1.Controls.Add(txtNovaSenha);
            groupBox1.Controls.Add(lblSenha);
            groupBox1.Location = new Point(69, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(380, 276);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Location = new Point(178, 207);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(37, 15);
            linkLogin.TabIndex = 4;
            linkLogin.TabStop = true;
            linkLogin.Text = "Login";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(136, 168);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(118, 35);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(82, 54);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(70, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Nova Senha";
            // 
            // txtConfirmSenha
            // 
            txtConfirmSenha.Location = new Point(82, 124);
            txtConfirmSenha.Name = "txtConfirmSenha";
            txtConfirmSenha.PasswordChar = '•';
            txtConfirmSenha.Size = new Size(222, 23);
            txtConfirmSenha.TabIndex = 2;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(82, 72);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(222, 23);
            txtNovaSenha.TabIndex = 1;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(79, 106);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(95, 15);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Confirmar senha";
            // 
            // MudarSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 381);
            Controls.Add(lblMudarSenha);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MudarSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MudarSenha";
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
    }
}
namespace Cadastro
{
    partial class Sistema
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
            lblEmail = new Label();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Algerian", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(200, 180);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(188, 30);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "FUNUNCIOU!!!";
            // 
            // Sistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 417);
            Controls.Add(lblEmail);
            Name = "Sistema";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
    }
}
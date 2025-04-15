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
            panel1 = new Panel();
            NomeUser = new Label();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(NomeUser);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(956, 64);
            panel1.TabIndex = 0;
            // 
            // NomeUser
            // 
            NomeUser.AutoSize = true;
            NomeUser.BackColor = Color.Green;
            NomeUser.Font = new Font("Segoe UI", 15F);
            NomeUser.ForeColor = SystemColors.ButtonHighlight;
            NomeUser.Location = new Point(181, 17);
            NomeUser.Name = "NomeUser";
            NomeUser.Size = new Size(0, 28);
            NomeUser.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(1, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(953, 546);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Sistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 603);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Sistema";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema";
            FormClosing += Sistema_FormClosing;
            Load += Sistema_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label NomeUser;
    }
}
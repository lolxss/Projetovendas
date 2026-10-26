namespace Projeto.Venda.Lolxss.view
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txtuser = new TextBox();
            txtpassword = new TextBox();
            button1 = new Button();
            lblinfo = new Label();
            SuspendLayout();
            // 
            // txtuser
            // 
            txtuser.Location = new Point(68, 55);
            txtuser.Name = "txtuser";
            txtuser.PlaceholderText = "usuario:";
            txtuser.Size = new Size(138, 23);
            txtuser.TabIndex = 0;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(68, 101);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.PlaceholderText = "senha:";
            txtpassword.Size = new Size(138, 23);
            txtpassword.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(96, 130);
            button1.Name = "button1";
            button1.Size = new Size(76, 24);
            button1.TabIndex = 2;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_entrar;
            // 
            // lblinfo
            // 
            lblinfo.AutoSize = true;
            lblinfo.Location = new Point(120, 229);
            lblinfo.Name = "lblinfo";
            lblinfo.Size = new Size(41, 15);
            lblinfo.TabIndex = 3;
            lblinfo.Text = "lblinfo";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(259, 308);
            Controls.Add(lblinfo);
            Controls.Add(button1);
            Controls.Add(txtpassword);
            Controls.Add(txtuser);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtuser;
        private TextBox txtpassword;
        private Button button1;
        private Label lblinfo;
    }
}
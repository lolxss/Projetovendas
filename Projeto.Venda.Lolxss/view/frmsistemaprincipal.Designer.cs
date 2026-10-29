namespace Projeto.Venda.Lolxss.view
{
    partial class frmsistemaprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsistemaprincipal));
            lblusername = new Label();
            btncadfuncionario = new Button();
            cad_prod = new Button();
            panel1 = new Panel();
            painelprincipal = new Panel();
            panel2 = new Panel();
            sair = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Location = new Point(30, 146);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(57, 15);
            lblusername.TabIndex = 0;
            lblusername.Text = "cadastros";
            // 
            // btncadfuncionario
            // 
            btncadfuncionario.Location = new Point(3, 164);
            btncadfuncionario.Name = "btncadfuncionario";
            btncadfuncionario.Size = new Size(115, 71);
            btncadfuncionario.TabIndex = 1;
            btncadfuncionario.Text = "cad_func";
            btncadfuncionario.UseVisualStyleBackColor = true;
            btncadfuncionario.Click += btncadfuncionario_Click;
            // 
            // cad_prod
            // 
            cad_prod.Location = new Point(3, 260);
            cad_prod.Name = "cad_prod";
            cad_prod.Size = new Size(115, 71);
            cad_prod.TabIndex = 2;
            cad_prod.Text = "cad_prod";
            cad_prod.UseVisualStyleBackColor = true;
            cad_prod.Click += cad_prod_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(painelprincipal);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(160, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 595);
            panel1.TabIndex = 3;
            // 
            // painelprincipal
            // 
            painelprincipal.Dock = DockStyle.Fill;
            painelprincipal.Location = new Point(0, 60);
            painelprincipal.Name = "painelprincipal";
            painelprincipal.Size = new Size(922, 535);
            painelprincipal.TabIndex = 5;
            painelprincipal.Paint += painelprincipal_Paint;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(922, 60);
            panel2.TabIndex = 4;
            // 
            // sair
            // 
            sair.Location = new Point(3, 353);
            sair.Name = "sair";
            sair.Size = new Size(112, 46);
            sair.TabIndex = 4;
            sair.Text = "sair";
            sair.UseVisualStyleBackColor = true;
            sair.Click += sair_Click;
            // 
            // frmsistemaprincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 595);
            Controls.Add(sair);
            Controls.Add(panel1);
            Controls.Add(cad_prod);
            Controls.Add(btncadfuncionario);
            Controls.Add(lblusername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmsistemaprincipal";
            Text = "sistema";
            Load += frmsistemaprincipal_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblusername;
        private Button btncadfuncionario;
        private Button cad_prod;
        private Panel panel1;
        private Panel painelprincipal;
        private Panel panel2;
        private Button sair;
    }
}
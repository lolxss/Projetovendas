namespace Projeto.Venda.Lolxss.view
{
    partial class FrmSistemaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSistemaPrincipal));
            lblusername = new Label();
            btncadfuncionario = new Button();
            cad_prod = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            painelprincipal = new Panel();
            lblTitulo = new Label();
            sair = new Button();
            usuario = new Button();
            cad_venda = new Button();
            lblnome = new Label();
            panel1.SuspendLayout();
            painelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusername.Location = new Point(24, 9);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(76, 20);
            lblusername.TabIndex = 0;
            lblusername.Text = "cadastros";
            // 
            // btncadfuncionario
            // 
            btncadfuncionario.Location = new Point(12, 36);
            btncadfuncionario.Name = "btncadfuncionario";
            btncadfuncionario.Size = new Size(115, 56);
            btncadfuncionario.TabIndex = 1;
            btncadfuncionario.Text = "Cadastro do funcionario";
            btncadfuncionario.UseVisualStyleBackColor = true;
            btncadfuncionario.Click += btncadfuncionario_Click;
            // 
            // cad_prod
            // 
            cad_prod.Location = new Point(143, 36);
            cad_prod.Name = "cad_prod";
            cad_prod.Size = new Size(115, 56);
            cad_prod.TabIndex = 2;
            cad_prod.Text = "Cadastro do produto";
            cad_prod.UseVisualStyleBackColor = true;
            cad_prod.Click += cad_prod_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(painelprincipal);
            panel1.Location = new Point(-1, 163);
            panel1.Name = "panel1";
            panel1.Size = new Size(1187, 551);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1181, 46);
            panel2.TabIndex = 4;
            // 
            // painelprincipal
            // 
            painelprincipal.Controls.Add(panel2);
            painelprincipal.Dock = DockStyle.Fill;
            painelprincipal.Location = new Point(0, 0);
            painelprincipal.Name = "painelprincipal";
            painelprincipal.Size = new Size(1187, 551);
            painelprincipal.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(472, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(270, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Seja Bem Vindo(a)";
            // 
            // sair
            // 
            sair.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sair.Location = new Point(955, 91);
            sair.Name = "sair";
            sair.Size = new Size(112, 30);
            sair.TabIndex = 4;
            sair.Text = "sair";
            sair.UseVisualStyleBackColor = true;
            sair.Click += sair_Click;
            // 
            // usuario
            // 
            usuario.Location = new Point(143, 111);
            usuario.Name = "usuario";
            usuario.Size = new Size(115, 47);
            usuario.TabIndex = 5;
            usuario.Text = "usuario";
            usuario.UseVisualStyleBackColor = true;
            usuario.Click += usuario_Click;
            // 
            // cad_venda
            // 
            cad_venda.Location = new Point(12, 102);
            cad_venda.Name = "cad_venda";
            cad_venda.Size = new Size(115, 56);
            cad_venda.TabIndex = 6;
            cad_venda.Text = "Cadastro da venda";
            cad_venda.UseVisualStyleBackColor = true;
            cad_venda.Click += cad_venda_Click;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnome.Location = new Point(596, 52);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(14, 21);
            lblnome.TabIndex = 7;
            lblnome.Text = ".";
            // 
            // FrmSistemaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 961);
            Controls.Add(lblnome);
            Controls.Add(sair);
            Controls.Add(lblTitulo);
            Controls.Add(panel1);
            Controls.Add(usuario);
            Controls.Add(btncadfuncionario);
            Controls.Add(cad_prod);
            Controls.Add(cad_venda);
            Controls.Add(lblusername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmSistemaPrincipal";
            Text = "sistema";
            Load += frmsistemaprincipal_Load;
            panel1.ResumeLayout(false);
            painelprincipal.ResumeLayout(false);
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
        private Button usuario;
        private Button cad_venda;
        private Label lblTitulo;
        private Label lblnome;
    }
}
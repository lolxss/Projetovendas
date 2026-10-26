namespace Projeto.Venda.Lolxss.view
{
    partial class frmfuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfuncionario));
            txtnome = new TextBox();
            txtsenha = new TextBox();
            txttelefone = new TextBox();
            txtrua = new TextBox();
            txtusuario = new TextBox();
            txtnumero = new TextBox();
            txtcomplemento = new TextBox();
            txtcep = new TextBox();
            txtcadastrar = new Button();
            txtsenha2 = new TextBox();
            SuspendLayout();
            // 
            // txtnome
            // 
            txtnome.Location = new Point(41, 63);
            txtnome.Name = "txtnome";
            txtnome.PlaceholderText = "nome";
            txtnome.Size = new Size(148, 23);
            txtnome.TabIndex = 0;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(320, 95);
            txtsenha.Name = "txtsenha";
            txtsenha.PasswordChar = '*';
            txtsenha.PlaceholderText = "senha";
            txtsenha.Size = new Size(120, 23);
            txtsenha.TabIndex = 7;
            // 
            // txttelefone
            // 
            txttelefone.Location = new Point(41, 101);
            txttelefone.Name = "txttelefone";
            txttelefone.PlaceholderText = "telefone";
            txttelefone.Size = new Size(151, 23);
            txttelefone.TabIndex = 1;
            // 
            // txtrua
            // 
            txtrua.Location = new Point(31, 235);
            txtrua.Name = "txtrua";
            txtrua.PlaceholderText = "rua";
            txtrua.Size = new Size(184, 23);
            txtrua.TabIndex = 5;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(320, 66);
            txtusuario.Name = "txtusuario";
            txtusuario.PlaceholderText = "usuario";
            txtusuario.Size = new Size(120, 23);
            txtusuario.TabIndex = 6;
            txtusuario.TextChanged += txtusuario_TextChanged;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(31, 206);
            txtnumero.Name = "txtnumero";
            txtnumero.PlaceholderText = "numero";
            txtnumero.Size = new Size(94, 23);
            txtnumero.TabIndex = 3;
            // 
            // txtcomplemento
            // 
            txtcomplemento.Location = new Point(131, 206);
            txtcomplemento.Name = "txtcomplemento";
            txtcomplemento.PlaceholderText = "complemento";
            txtcomplemento.Size = new Size(84, 23);
            txtcomplemento.TabIndex = 4;
            txtcomplemento.TextChanged += txtcomplemento_TextChanged;
            // 
            // txtcep
            // 
            txtcep.Location = new Point(31, 177);
            txtcep.Name = "txtcep";
            txtcep.PlaceholderText = "cep";
            txtcep.Size = new Size(184, 23);
            txtcep.TabIndex = 2;
            // 
            // txtcadastrar
            // 
            txtcadastrar.Location = new Point(327, 202);
            txtcadastrar.Name = "txtcadastrar";
            txtcadastrar.Size = new Size(113, 56);
            txtcadastrar.TabIndex = 9;
            txtcadastrar.Text = "cadastrar";
            txtcadastrar.UseVisualStyleBackColor = true;
            txtcadastrar.Click += btnCadastrar_click;
            // 
            // txtsenha2
            // 
            txtsenha2.Location = new Point(320, 124);
            txtsenha2.Name = "txtsenha2";
            txtsenha2.PasswordChar = '*';
            txtsenha2.PlaceholderText = "confirmar senha";
            txtsenha2.Size = new Size(120, 23);
            txtsenha2.TabIndex = 8;
            // 
            // frmfuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 364);
            Controls.Add(txtsenha2);
            Controls.Add(txtcadastrar);
            Controls.Add(txtcep);
            Controls.Add(txtcomplemento);
            Controls.Add(txtnumero);
            Controls.Add(txtusuario);
            Controls.Add(txtrua);
            Controls.Add(txttelefone);
            Controls.Add(txtsenha);
            Controls.Add(txtnome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmfuncionario";
            Text = "frmfuncionario";
            Load += frmfuncionario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnome;
        private TextBox txtsenha;
        private TextBox txttelefone;
        private TextBox txtrua;
        private TextBox txtusuario;
        private TextBox txtnumero;
        private TextBox txtcomplemento;
        private TextBox txtcep;
        private Button txtcadastrar;
        private TextBox txtsenha2;
    }
}
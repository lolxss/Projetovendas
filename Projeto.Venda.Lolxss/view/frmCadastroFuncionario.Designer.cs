namespace Projeto.Venda.Lolxss.view
{
    partial class frmCadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFuncionario));
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
            dgvfuncionario = new DataGridView();
            cbxadm = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvfuncionario).BeginInit();
            SuspendLayout();
            // 
            // txtnome
            // 
            txtnome.Location = new Point(15, 12);
            txtnome.Name = "txtnome";
            txtnome.PlaceholderText = "nome";
            txtnome.Size = new Size(148, 23);
            txtnome.TabIndex = 0;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(419, 41);
            txtsenha.Name = "txtsenha";
            txtsenha.PasswordChar = '*';
            txtsenha.PlaceholderText = "senha";
            txtsenha.Size = new Size(120, 23);
            txtsenha.TabIndex = 7;
            // 
            // txttelefone
            // 
            txttelefone.Location = new Point(12, 41);
            txttelefone.Name = "txttelefone";
            txttelefone.PlaceholderText = "telefone";
            txttelefone.Size = new Size(151, 23);
            txttelefone.TabIndex = 1;
            // 
            // txtrua
            // 
            txtrua.Location = new Point(183, 70);
            txtrua.Name = "txtrua";
            txtrua.PlaceholderText = "rua";
            txtrua.Size = new Size(184, 23);
            txtrua.TabIndex = 5;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(419, 12);
            txtusuario.Name = "txtusuario";
            txtusuario.PlaceholderText = "usuario";
            txtusuario.Size = new Size(120, 23);
            txtusuario.TabIndex = 6;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(183, 41);
            txtnumero.Name = "txtnumero";
            txtnumero.PlaceholderText = "numero";
            txtnumero.Size = new Size(94, 23);
            txtnumero.TabIndex = 3;
            // 
            // txtcomplemento
            // 
            txtcomplemento.Location = new Point(283, 41);
            txtcomplemento.Name = "txtcomplemento";
            txtcomplemento.PlaceholderText = "complemento";
            txtcomplemento.Size = new Size(84, 23);
            txtcomplemento.TabIndex = 4;
            // 
            // txtcep
            // 
            txtcep.Location = new Point(183, 12);
            txtcep.Name = "txtcep";
            txtcep.PlaceholderText = "cep";
            txtcep.Size = new Size(184, 23);
            txtcep.TabIndex = 2;
            // 
            // txtcadastrar
            // 
            txtcadastrar.Location = new Point(559, 8);
            txtcadastrar.Name = "txtcadastrar";
            txtcadastrar.Size = new Size(113, 56);
            txtcadastrar.TabIndex = 9;
            txtcadastrar.Text = "cadastrar";
            txtcadastrar.UseVisualStyleBackColor = true;
            txtcadastrar.Click += btnCadastrar_click;
            // 
            // txtsenha2
            // 
            txtsenha2.Location = new Point(419, 70);
            txtsenha2.Name = "txtsenha2";
            txtsenha2.PasswordChar = '*';
            txtsenha2.PlaceholderText = "confirmar senha";
            txtsenha2.Size = new Size(120, 23);
            txtsenha2.TabIndex = 8;
            // 
            // dgvfuncionario
            // 
            dgvfuncionario.AllowUserToDeleteRows = false;
            dgvfuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvfuncionario.Location = new Point(12, 152);
            dgvfuncionario.Name = "dgvfuncionario";
            dgvfuncionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvfuncionario.Size = new Size(674, 256);
            dgvfuncionario.TabIndex = 10;
            // 
            // cbxadm
            // 
            cbxadm.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxadm.FormattingEnabled = true;
            cbxadm.Items.AddRange(new object[] { "EMPREGADO", "ADM" });
            cbxadm.Location = new Point(559, 82);
            cbxadm.Name = "cbxadm";
            cbxadm.Size = new Size(121, 23);
            cbxadm.TabIndex = 11;
            // 
            // frmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 475);
            Controls.Add(cbxadm);
            Controls.Add(dgvfuncionario);
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
            Name = "frmCadastroFuncionario";
            Text = "frmCadastroFuncionario";
            Load += FrmFuncionario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvfuncionario).EndInit();
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
        private DataGridView dgvfuncionario;
        private ComboBox cbxadm;
    }
}
namespace Projeto.Venda.Lolxss.view
{
    partial class CadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFuncionario));
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvfuncionario).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtnome
            // 
            txtnome.Location = new Point(69, 57);
            txtnome.Name = "txtnome";
            txtnome.PlaceholderText = "nome";
            txtnome.Size = new Size(148, 23);
            txtnome.TabIndex = 0;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(75, 81);
            txtsenha.Name = "txtsenha";
            txtsenha.PasswordChar = '*';
            txtsenha.PlaceholderText = "senha";
            txtsenha.Size = new Size(104, 23);
            txtsenha.TabIndex = 7;
            // 
            // txttelefone
            // 
            txttelefone.Location = new Point(69, 98);
            txttelefone.Name = "txttelefone";
            txttelefone.PlaceholderText = "telefone";
            txttelefone.Size = new Size(151, 23);
            txttelefone.TabIndex = 1;
            // 
            // txtrua
            // 
            txtrua.Location = new Point(56, 199);
            txtrua.Name = "txtrua";
            txtrua.PlaceholderText = "rua";
            txtrua.Size = new Size(184, 23);
            txtrua.TabIndex = 5;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(75, 46);
            txtusuario.Name = "txtusuario";
            txtusuario.PlaceholderText = "usuario";
            txtusuario.Size = new Size(104, 23);
            txtusuario.TabIndex = 6;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(56, 170);
            txtnumero.Name = "txtnumero";
            txtnumero.PlaceholderText = "numero";
            txtnumero.Size = new Size(94, 23);
            txtnumero.TabIndex = 3;
            // 
            // txtcomplemento
            // 
            txtcomplemento.Location = new Point(156, 170);
            txtcomplemento.Name = "txtcomplemento";
            txtcomplemento.PlaceholderText = "complemento";
            txtcomplemento.Size = new Size(84, 23);
            txtcomplemento.TabIndex = 4;
            // 
            // txtcep
            // 
            txtcep.Location = new Point(56, 141);
            txtcep.Name = "txtcep";
            txtcep.PlaceholderText = "cep";
            txtcep.Size = new Size(184, 23);
            txtcep.TabIndex = 2;
            // 
            // txtcadastrar
            // 
            txtcadastrar.Location = new Point(82, 170);
            txtcadastrar.Name = "txtcadastrar";
            txtcadastrar.Size = new Size(97, 56);
            txtcadastrar.TabIndex = 9;
            txtcadastrar.Text = "cadastrar";
            txtcadastrar.UseVisualStyleBackColor = true;
            txtcadastrar.Click += btnCadastrar_click;
            // 
            // txtsenha2
            // 
            txtsenha2.Location = new Point(75, 110);
            txtsenha2.Name = "txtsenha2";
            txtsenha2.PasswordChar = '*';
            txtsenha2.PlaceholderText = "confirmar senha";
            txtsenha2.Size = new Size(104, 23);
            txtsenha2.TabIndex = 8;
            // 
            // dgvfuncionario
            // 
            dgvfuncionario.AllowUserToDeleteRows = false;
            dgvfuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvfuncionario.Dock = DockStyle.Fill;
            dgvfuncionario.Location = new Point(18, 298);
            dgvfuncionario.Margin = new Padding(18, 15, 18, 15);
            dgvfuncionario.Name = "dgvfuncionario";
            dgvfuncionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvfuncionario.Size = new Size(553, 413);
            dgvfuncionario.TabIndex = 10;
            // 
            // cbxadm
            // 
            cbxadm.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxadm.FormattingEnabled = true;
            cbxadm.Items.AddRange(new object[] { "EMPREGADO", "ADM" });
            cbxadm.Location = new Point(75, 139);
            cbxadm.Name = "cbxadm";
            cbxadm.Size = new Size(105, 23);
            cbxadm.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvfuncionario, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 283F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 297F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(589, 726);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(583, 277);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.Controls.Add(txtcadastrar);
            panel3.Controls.Add(cbxadm);
            panel3.Controls.Add(txtsenha);
            panel3.Controls.Add(txtusuario);
            panel3.Controls.Add(txtsenha2);
            panel3.Location = new Point(340, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(240, 274);
            panel3.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtnome);
            panel2.Controls.Add(txttelefone);
            panel2.Controls.Add(txtcep);
            panel2.Controls.Add(txtrua);
            panel2.Controls.Add(txtnumero);
            panel2.Controls.Add(txtcomplemento);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 271);
            panel2.TabIndex = 13;
            // 
            // CadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 726);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastroFuncionario";
            Text = "Cadastro do Funcionario";
            Load += FrmFuncionario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvfuncionario).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
    }
}
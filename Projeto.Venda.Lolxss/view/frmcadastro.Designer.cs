namespace Projeto.Venda.Lolxss.view
{
    partial class frmcadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcadastro));
            txtpreco = new TextBox();
            txtmarca = new TextBox();
            txtnome = new TextBox();
            quantidade = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            btn_cad = new Button();
            dgvprodutos = new DataGridView();
            atualizar = new Button();
            excluir = new Button();
            ((System.ComponentModel.ISupportInitialize)quantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvprodutos).BeginInit();
            SuspendLayout();
            // 
            // txtpreco
            // 
            txtpreco.Location = new Point(38, 71);
            txtpreco.Name = "txtpreco";
            txtpreco.PlaceholderText = "00,00";
            txtpreco.Size = new Size(135, 23);
            txtpreco.TabIndex = 0;
            // 
            // txtmarca
            // 
            txtmarca.Location = new Point(189, 12);
            txtmarca.Name = "txtmarca";
            txtmarca.PlaceholderText = "marca";
            txtmarca.Size = new Size(130, 23);
            txtmarca.TabIndex = 1;
            // 
            // txtnome
            // 
            txtnome.Location = new Point(38, 12);
            txtnome.Name = "txtnome";
            txtnome.PlaceholderText = "nome";
            txtnome.Size = new Size(135, 23);
            txtnome.TabIndex = 2;
            // 
            // quantidade
            // 
            quantidade.Location = new Point(189, 72);
            quantidade.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            quantidade.Name = "quantidade";
            quantidade.Size = new Size(130, 23);
            quantidade.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 53);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 5;
            label1.Text = "quantidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 53);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 6;
            label2.Text = "preco";
            // 
            // btn_cad
            // 
            btn_cad.Location = new Point(339, 30);
            btn_cad.Name = "btn_cad";
            btn_cad.Size = new Size(75, 64);
            btn_cad.TabIndex = 8;
            btn_cad.Text = "cadastro";
            btn_cad.UseVisualStyleBackColor = true;
            btn_cad.Click += btn_cad_Click;
            // 
            // dgvprodutos
            // 
            dgvprodutos.AllowUserToAddRows = false;
            dgvprodutos.AllowUserToDeleteRows = false;
            dgvprodutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvprodutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvprodutos.Location = new Point(22, 129);
            dgvprodutos.MultiSelect = false;
            dgvprodutos.Name = "dgvprodutos";
            dgvprodutos.ReadOnly = true;
            dgvprodutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvprodutos.Size = new Size(802, 440);
            dgvprodutos.TabIndex = 9;
            dgvprodutos.CellContentClick += dgvprodutos_CellContentClick;
            dgvprodutos.CellContentDoubleClick += dgvprodutos_CellContentDoubleClick;
            dgvprodutos.CellDoubleClick += dgvprodutos_CellDoubleClick;
            // 
            // atualizar
            // 
            atualizar.Enabled = false;
            atualizar.Location = new Point(429, 30);
            atualizar.Name = "atualizar";
            atualizar.Size = new Size(75, 23);
            atualizar.TabIndex = 10;
            atualizar.Text = "atualizar";
            atualizar.UseVisualStyleBackColor = true;
            atualizar.Click += atualizar_Click;
            // 
            // excluir
            // 
            excluir.Enabled = false;
            excluir.Location = new Point(429, 70);
            excluir.Name = "excluir";
            excluir.Size = new Size(75, 23);
            excluir.TabIndex = 11;
            excluir.Text = "excluir";
            excluir.UseVisualStyleBackColor = true;
            // 
            // frmcadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 581);
            Controls.Add(excluir);
            Controls.Add(atualizar);
            Controls.Add(dgvprodutos);
            Controls.Add(btn_cad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(quantidade);
            Controls.Add(txtnome);
            Controls.Add(txtmarca);
            Controls.Add(txtpreco);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmcadastro";
            Text = "frmvenda";
            Load += frmcadastro_Load;
            ((System.ComponentModel.ISupportInitialize)quantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvprodutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtpreco;
        private TextBox txtmarca;
        private TextBox txtnome;
        private NumericUpDown quantidade;
        private Label label1;
        private Label label2;
        private Button btn_cad;
        private DataGridView dgvprodutos;
        private Button atualizar;
        private Button excluir;
    }
}
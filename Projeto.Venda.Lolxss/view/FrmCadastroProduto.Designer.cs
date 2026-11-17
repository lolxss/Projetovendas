namespace Projeto.Venda.Lolxss.view
{
    partial class CadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProduto));
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
            anterior = new Button();
            proximo = new Button();
            lbl = new Label();
            cbxquantidade = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)quantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvprodutos).BeginInit();
            SuspendLayout();
            // 
            // txtpreco
            // 
            txtpreco.Location = new Point(23, 60);
            txtpreco.Name = "txtpreco";
            txtpreco.PlaceholderText = "00,00";
            txtpreco.Size = new Size(211, 23);
            txtpreco.TabIndex = 0;
            // 
            // txtmarca
            // 
            txtmarca.Location = new Point(240, 60);
            txtmarca.Name = "txtmarca";
            txtmarca.Size = new Size(266, 23);
            txtmarca.TabIndex = 1;
            // 
            // txtnome
            // 
            txtnome.Location = new Point(23, 19);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(347, 23);
            txtnome.TabIndex = 2;
            // 
            // quantidade
            // 
            quantidade.Location = new Point(376, 19);
            quantidade.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            quantidade.Name = "quantidade";
            quantidade.Size = new Size(130, 23);
            quantidade.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(376, 1);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 5;
            label1.Text = "Quantidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 45);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 6;
            label2.Text = "Preço";
            // 
            // btn_cad
            // 
            btn_cad.Location = new Point(532, 19);
            btn_cad.Name = "btn_cad";
            btn_cad.Size = new Size(75, 70);
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
            dgvprodutos.Location = new Point(23, 100);
            dgvprodutos.MultiSelect = false;
            dgvprodutos.Name = "dgvprodutos";
            dgvprodutos.ReadOnly = true;
            dgvprodutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvprodutos.Size = new Size(802, 440);
            dgvprodutos.TabIndex = 9;
            dgvprodutos.CellDoubleClick += dgvprodutos_CellDoubleClick;
            // 
            // atualizar
            // 
            atualizar.Enabled = false;
            atualizar.Location = new Point(624, 45);
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
            excluir.Location = new Point(624, 17);
            excluir.Name = "excluir";
            excluir.Size = new Size(75, 23);
            excluir.TabIndex = 11;
            excluir.Text = "excluir";
            excluir.UseVisualStyleBackColor = true;
            excluir.Click += excluir_Click;
            // 
            // anterior
            // 
            anterior.Location = new Point(74, 546);
            anterior.Name = "anterior";
            anterior.Size = new Size(75, 23);
            anterior.TabIndex = 12;
            anterior.Text = "< Anterior";
            anterior.UseVisualStyleBackColor = true;
            anterior.Click += anterior_Click;
            // 
            // proximo
            // 
            proximo.Location = new Point(734, 546);
            proximo.Name = "proximo";
            proximo.Size = new Size(75, 23);
            proximo.TabIndex = 13;
            proximo.Text = "Proximo >";
            proximo.UseVisualStyleBackColor = true;
            proximo.Click += proximo_Click;
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.Location = new Point(316, 556);
            lbl.Name = "lbl";
            lbl.Size = new Size(187, 23);
            lbl.TabIndex = 14;
            lbl.Text = "pagina 1 de 5";
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbxquantidade
            // 
            cbxquantidade.FormattingEnabled = true;
            cbxquantidade.Items.AddRange(new object[] { "10", "20", "50", "100" });
            cbxquantidade.Location = new Point(624, 71);
            cbxquantidade.Name = "cbxquantidade";
            cbxquantidade.Size = new Size(94, 23);
            cbxquantidade.TabIndex = 15;
            cbxquantidade.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 1);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 16;
            label3.Text = "Nome do produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 45);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 16;
            label4.Text = "Marca do produto";
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 581);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbxquantidade);
            Controls.Add(lbl);
            Controls.Add(proximo);
            Controls.Add(anterior);
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
            Name = "FrmCadastroProduto";
            Text = "frmvenda";
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
        private Button anterior;
        private Button proximo;
        private Label lbl;
        private ComboBox cbxquantidade;
        private Label label3;
        private Label label4;
    }
}
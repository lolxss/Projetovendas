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
            dgvprodutos = new DataGridView();
            anterior = new Button();
            proximo = new Button();
            lbl = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            excluir = new Button();
            cbxquantidade = new ComboBox();
            label4 = new Label();
            atualizar = new Button();
            label3 = new Label();
            btn_cad = new Button();
            quantidade = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            txtpreco = new TextBox();
            txtnome = new TextBox();
            txtmarca = new TextBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvprodutos).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantidade).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvprodutos
            // 
            dgvprodutos.AllowUserToAddRows = false;
            dgvprodutos.AllowUserToDeleteRows = false;
            dgvprodutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvprodutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvprodutos.Dock = DockStyle.Fill;
            dgvprodutos.Location = new Point(15, 150);
            dgvprodutos.Margin = new Padding(15, 18, 15, 18);
            dgvprodutos.MultiSelect = false;
            dgvprodutos.Name = "dgvprodutos";
            dgvprodutos.ReadOnly = true;
            dgvprodutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvprodutos.Size = new Size(567, 405);
            dgvprodutos.TabIndex = 9;
            dgvprodutos.CellDoubleClick += dgvprodutos_CellDoubleClick;
            // 
            // anterior
            // 
            anterior.Location = new Point(3, 15);
            anterior.Name = "anterior";
            anterior.Size = new Size(75, 23);
            anterior.TabIndex = 12;
            anterior.Text = "< Anterior";
            anterior.UseVisualStyleBackColor = true;
            anterior.Click += anterior_Click;
            // 
            // proximo
            // 
            proximo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            proximo.Location = new Point(516, 13);
            proximo.Name = "proximo";
            proximo.Size = new Size(75, 23);
            proximo.TabIndex = 13;
            proximo.Text = "Proximo >";
            proximo.UseVisualStyleBackColor = true;
            proximo.Click += proximo_Click;
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.Top;
            lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.Location = new Point(225, 15);
            lbl.Name = "lbl";
            lbl.Size = new Size(165, 23);
            lbl.TabIndex = 14;
            lbl.Text = "pagina 1 de 5";
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Click += lbl_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvprodutos, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 132F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel1.Size = new Size(597, 624);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.Controls.Add(excluir);
            panel1.Controls.Add(cbxquantidade);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(atualizar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_cad);
            panel1.Controls.Add(quantidade);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtpreco);
            panel1.Controls.Add(txtnome);
            panel1.Controls.Add(txtmarca);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 126);
            panel1.TabIndex = 0;
            // 
            // excluir
            // 
            excluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            excluir.Enabled = false;
            excluir.Location = new Point(433, 21);
            excluir.Name = "excluir";
            excluir.Size = new Size(75, 23);
            excluir.TabIndex = 11;
            excluir.Text = "excluir";
            excluir.UseVisualStyleBackColor = true;
            excluir.Click += excluir_Click;
            // 
            // cbxquantidade
            // 
            cbxquantidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxquantidade.FormattingEnabled = true;
            cbxquantidade.Items.AddRange(new object[] { "10", "20", "50", "100" });
            cbxquantidade.Location = new Point(433, 82);
            cbxquantidade.Name = "cbxquantidade";
            cbxquantidade.Size = new Size(94, 23);
            cbxquantidade.TabIndex = 15;
            cbxquantidade.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 52);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 16;
            label4.Text = "Marca do produto";
            // 
            // atualizar
            // 
            atualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            atualizar.Enabled = false;
            atualizar.Location = new Point(336, 19);
            atualizar.Name = "atualizar";
            atualizar.Size = new Size(75, 23);
            atualizar.TabIndex = 10;
            atualizar.Text = "atualizar";
            atualizar.UseVisualStyleBackColor = true;
            atualizar.Click += atualizar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 2);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 16;
            label3.Text = "Nome do produto";
            // 
            // btn_cad
            // 
            btn_cad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_cad.Location = new Point(315, 52);
            btn_cad.Name = "btn_cad";
            btn_cad.Size = new Size(75, 53);
            btn_cad.TabIndex = 8;
            btn_cad.Text = "cadastro";
            btn_cad.UseVisualStyleBackColor = true;
            btn_cad.Click += btn_cad_Click;
            // 
            // quantidade
            // 
            quantidade.Location = new Point(202, 21);
            quantidade.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            quantidade.Name = "quantidade";
            quantidade.Size = new Size(101, 23);
            quantidade.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 54);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 6;
            label2.Text = "Preço";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 4);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 5;
            label1.Text = "Quantidade";
            // 
            // txtpreco
            // 
            txtpreco.Location = new Point(163, 70);
            txtpreco.Name = "txtpreco";
            txtpreco.PlaceholderText = "00,00";
            txtpreco.Size = new Size(128, 23);
            txtpreco.TabIndex = 0;
            // 
            // txtnome
            // 
            txtnome.Location = new Point(3, 20);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(170, 23);
            txtnome.TabIndex = 2;
            // 
            // txtmarca
            // 
            txtmarca.Location = new Point(3, 70);
            txtmarca.Name = "txtmarca";
            txtmarca.Size = new Size(144, 23);
            txtmarca.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(lbl);
            panel2.Controls.Add(proximo);
            panel2.Controls.Add(anterior);
            panel2.Location = new Point(3, 576);
            panel2.Name = "panel2";
            panel2.Size = new Size(591, 45);
            panel2.TabIndex = 10;
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 624);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastroProduto";
            Text = "Cadastro dos Produtos";
            Load += CadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvprodutos).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantidade).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvprodutos;
        private Button anterior;
        private Button proximo;
        private Label lbl;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button excluir;
        private ComboBox cbxquantidade;
        private Label label4;
        private Button atualizar;
        private Label label3;
        private Button btn_cad;
        private NumericUpDown quantidade;
        private Label label2;
        private Label label1;
        private TextBox txtpreco;
        private TextBox txtnome;
        private TextBox txtmarca;
        private Panel panel2;
    }
}
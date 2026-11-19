namespace Projeto.Venda.Lolxss.view
{
    partial class CadastroVenda
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
            dgvcompras = new DataGridView();
            btncadastrar = new Button();
            precototal = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnadicionar = new Button();
            numquantidade = new NumericUpDown();
            cbxprodutos = new ComboBox();
            lblquantidade = new Label();
            lblprecounitario = new Label();
            panel2 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvcompras).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numquantidade).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvcompras
            // 
            dgvcompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcompras.Dock = DockStyle.Fill;
            dgvcompras.Location = new Point(3, 144);
            dgvcompras.Name = "dgvcompras";
            dgvcompras.Size = new Size(599, 448);
            dgvcompras.TabIndex = 4;
            dgvcompras.CellContentDoubleClick += dgvcompras_CellContentDoubleClick;
            // 
            // btncadastrar
            // 
            btncadastrar.Location = new Point(24, 52);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(109, 53);
            btncadastrar.TabIndex = 6;
            btncadastrar.Text = "cadastrar";
            btncadastrar.UseVisualStyleBackColor = true;
            btncadastrar.Click += btncadastrar_Click;
            // 
            // precototal
            // 
            precototal.Anchor = AnchorStyles.Top;
            precototal.AutoSize = true;
            precototal.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            precototal.Location = new Point(46, 9);
            precototal.Name = "precototal";
            precototal.Size = new Size(313, 40);
            precototal.TabIndex = 7;
            precototal.Text = "total da venda xxxxxxxx";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Controls.Add(dgvcompras, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 114F));
            tableLayoutPanel1.Size = new Size(605, 709);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnadicionar);
            panel1.Controls.Add(numquantidade);
            panel1.Controls.Add(cbxprodutos);
            panel1.Controls.Add(lblquantidade);
            panel1.Controls.Add(lblprecounitario);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 135);
            panel1.TabIndex = 0;
            // 
            // btnadicionar
            // 
            btnadicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnadicionar.Location = new Point(489, 56);
            btnadicionar.Name = "btnadicionar";
            btnadicionar.Size = new Size(75, 23);
            btnadicionar.TabIndex = 2;
            btnadicionar.Text = "adicionar";
            btnadicionar.UseVisualStyleBackColor = true;
            btnadicionar.Click += btnadicionar_Click;
            // 
            // numquantidade
            // 
            numquantidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numquantidade.Location = new Point(444, 85);
            numquantidade.Name = "numquantidade";
            numquantidade.Size = new Size(120, 23);
            numquantidade.TabIndex = 8;
            // 
            // cbxprodutos
            // 
            cbxprodutos.Anchor = AnchorStyles.Top;
            cbxprodutos.FormattingEnabled = true;
            cbxprodutos.Location = new Point(38, 13);
            cbxprodutos.Name = "cbxprodutos";
            cbxprodutos.Size = new Size(504, 23);
            cbxprodutos.TabIndex = 3;
            cbxprodutos.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblquantidade
            // 
            lblquantidade.AutoSize = true;
            lblquantidade.Location = new Point(16, 85);
            lblquantidade.Name = "lblquantidade";
            lblquantidade.Size = new Size(151, 15);
            lblquantidade.TabIndex = 5;
            lblquantidade.Text = "quantidade disponivel: XXX";
            // 
            // lblprecounitario
            // 
            lblprecounitario.AutoSize = true;
            lblprecounitario.Location = new Point(16, 49);
            lblprecounitario.Name = "lblprecounitario";
            lblprecounitario.Size = new Size(134, 15);
            lblprecounitario.TabIndex = 0;
            lblprecounitario.Text = "preço unitario: R$ XX,XX";
            // 
            // panel2
            // 
            panel2.Controls.Add(precototal);
            panel2.Controls.Add(btncadastrar);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 598);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 108);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 79);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // CadastroVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 709);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Name = "CadastroVenda";
            Text = "Cadastro Venda";
            Load += frmcadproduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvcompras).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numquantidade).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvcompras;
        private Button btncadastrar;
        private Label precototal;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnadicionar;
        private NumericUpDown numquantidade;
        private ComboBox cbxprodutos;
        private Label lblquantidade;
        private Label lblprecounitario;
        private Panel panel2;
        private Label label2;
    }
}
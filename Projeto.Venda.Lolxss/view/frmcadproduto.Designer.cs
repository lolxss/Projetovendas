namespace Projeto.Venda.Lolxss.view
{
    partial class frmcadproduto
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
            lblprecounitario = new Label();
            label2 = new Label();
            btnadicionar = new Button();
            cbxprodutos = new ComboBox();
            dgvcompras = new DataGridView();
            lblquantidade = new Label();
            btncadastrar = new Button();
            precototal = new Label();
            numquantidade = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvcompras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numquantidade).BeginInit();
            SuspendLayout();
            // 
            // lblprecounitario
            // 
            lblprecounitario.AutoSize = true;
            lblprecounitario.Location = new Point(21, 47);
            lblprecounitario.Name = "lblprecounitario";
            lblprecounitario.Size = new Size(134, 15);
            lblprecounitario.TabIndex = 0;
            lblprecounitario.Text = "preço unitario: R$ XX,XX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 79);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // btnadicionar
            // 
            btnadicionar.Location = new Point(506, 47);
            btnadicionar.Name = "btnadicionar";
            btnadicionar.Size = new Size(75, 23);
            btnadicionar.TabIndex = 2;
            btnadicionar.Text = "adicionar";
            btnadicionar.UseVisualStyleBackColor = true;
            btnadicionar.Click += btnadicionar_Click;
            // 
            // cbxprodutos
            // 
            cbxprodutos.FormattingEnabled = true;
            cbxprodutos.Location = new Point(21, 12);
            cbxprodutos.Name = "cbxprodutos";
            cbxprodutos.Size = new Size(560, 23);
            cbxprodutos.TabIndex = 3;
            cbxprodutos.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dgvcompras
            // 
            dgvcompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcompras.Location = new Point(21, 100);
            dgvcompras.Name = "dgvcompras";
            dgvcompras.Size = new Size(578, 259);
            dgvcompras.TabIndex = 4;
            dgvcompras.CellContentDoubleClick += dgvcompras_CellContentDoubleClick;
            // 
            // lblquantidade
            // 
            lblquantidade.AutoSize = true;
            lblquantidade.Location = new Point(21, 79);
            lblquantidade.Name = "lblquantidade";
            lblquantidade.Size = new Size(151, 15);
            lblquantidade.TabIndex = 5;
            lblquantidade.Text = "quantidade disponivel: XXX";
            // 
            // btncadastrar
            // 
            btncadastrar.Location = new Point(61, 377);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(109, 53);
            btncadastrar.TabIndex = 6;
            btncadastrar.Text = "cadastrar";
            btncadastrar.UseVisualStyleBackColor = true;
            btncadastrar.Click += btncadastrar_Click;
            // 
            // precototal
            // 
            precototal.AutoSize = true;
            precototal.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            precototal.Location = new Point(268, 390);
            precototal.Name = "precototal";
            precototal.Size = new Size(313, 40);
            precototal.TabIndex = 7;
            precototal.Text = "total da venda xxxxxxxx";
            // 
            // numquantidade
            // 
            numquantidade.Location = new Point(479, 71);
            numquantidade.Name = "numquantidade";
            numquantidade.Size = new Size(120, 23);
            numquantidade.TabIndex = 8;
            // 
            // frmcadproduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 466);
            Controls.Add(numquantidade);
            Controls.Add(precototal);
            Controls.Add(btncadastrar);
            Controls.Add(lblquantidade);
            Controls.Add(dgvcompras);
            Controls.Add(cbxprodutos);
            Controls.Add(btnadicionar);
            Controls.Add(label2);
            Controls.Add(lblprecounitario);
            Name = "frmcadproduto";
            Text = "frmcadproduto";
            Load += frmcadproduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvcompras).EndInit();
            ((System.ComponentModel.ISupportInitialize)numquantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblprecounitario;
        private Label label2;
        private Button btnadicionar;
        private ComboBox cbxprodutos;
        private DataGridView dgvcompras;
        private Label lblquantidade;
        private Button btncadastrar;
        private Label precototal;
        private NumericUpDown numquantidade;
    }
}
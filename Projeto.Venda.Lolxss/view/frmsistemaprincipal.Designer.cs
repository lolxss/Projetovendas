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
            SuspendLayout();
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Location = new Point(371, 224);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(57, 15);
            lblusername.TabIndex = 0;
            lblusername.Text = "cadastros";
            // 
            // btncadfuncionario
            // 
            btncadfuncionario.Location = new Point(185, 196);
            btncadfuncionario.Name = "btncadfuncionario";
            btncadfuncionario.Size = new Size(115, 71);
            btncadfuncionario.TabIndex = 1;
            btncadfuncionario.Text = "cad_func";
            btncadfuncionario.UseVisualStyleBackColor = true;
            btncadfuncionario.Click += btncadfuncionario_Click;
            // 
            // cad_prod
            // 
            cad_prod.Location = new Point(489, 196);
            cad_prod.Name = "cad_prod";
            cad_prod.Size = new Size(115, 71);
            cad_prod.TabIndex = 2;
            cad_prod.Text = "cad_prod";
            cad_prod.UseVisualStyleBackColor = true;
            cad_prod.Click += cad_prod_Click;
            // 
            // frmsistemaprincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cad_prod);
            Controls.Add(btncadfuncionario);
            Controls.Add(lblusername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmsistemaprincipal";
            Text = "sistema";
            Load += frmsistemaprincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblusername;
        private Button btncadfuncionario;
        private Button cad_prod;
    }
}
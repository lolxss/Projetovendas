namespace Projeto.Venda.Lolxss.view
{
    partial class perfiluser
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
            bv = new Label();
            se = new Label();
            aq = new Label();
            xd = new Label();
            ln = new Label();
            label6 = new Label();
            usuariobox = new TextBox();
            nomebox = new TextBox();
            cepbox = new TextBox();
            telefonebox = new TextBox();
            ruabox = new TextBox();
            compbox = new TextBox();
            rua = new Label();
            numerobox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            enderecobox = new TextBox();
            SuspendLayout();
            // 
            // bv
            // 
            bv.AutoSize = true;
            bv.Location = new Point(12, 26);
            bv.Name = "bv";
            bv.Size = new Size(41, 15);
            bv.TabIndex = 0;
            bv.Text = "nome:";
            // 
            // se
            // 
            se.AutoSize = true;
            se.Location = new Point(12, 107);
            se.Name = "se";
            se.Size = new Size(27, 15);
            se.TabIndex = 1;
            se.Text = "rua:";
            // 
            // aq
            // 
            aq.AutoSize = true;
            aq.Location = new Point(5, 68);
            aq.Name = "aq";
            aq.Size = new Size(53, 15);
            aq.TabIndex = 2;
            aq.Text = "telefone:";
            // 
            // xd
            // 
            xd.AutoSize = true;
            xd.Location = new Point(12, 138);
            xd.Name = "xd";
            xd.Size = new Size(29, 15);
            xd.TabIndex = 3;
            xd.Text = "cep:";
            // 
            // ln
            // 
            ln.AutoSize = true;
            ln.Location = new Point(176, 41);
            ln.Name = "ln";
            ln.Size = new Size(49, 15);
            ln.TabIndex = 4;
            ln.Text = "usuario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(176, 77);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 5;
            label6.Text = "complemento";
            // 
            // usuariobox
            // 
            usuariobox.Location = new Point(254, 33);
            usuariobox.Name = "usuariobox";
            usuariobox.Size = new Size(100, 23);
            usuariobox.TabIndex = 8;
            // 
            // nomebox
            // 
            nomebox.Location = new Point(59, 23);
            nomebox.Name = "nomebox";
            nomebox.Size = new Size(100, 23);
            nomebox.TabIndex = 9;
            // 
            // cepbox
            // 
            cepbox.Location = new Point(59, 138);
            cepbox.Name = "cepbox";
            cepbox.Size = new Size(100, 23);
            cepbox.TabIndex = 11;
            // 
            // telefonebox
            // 
            telefonebox.Location = new Point(64, 65);
            telefonebox.Name = "telefonebox";
            telefonebox.Size = new Size(100, 23);
            telefonebox.TabIndex = 12;
            // 
            // ruabox
            // 
            ruabox.Location = new Point(64, 99);
            ruabox.Name = "ruabox";
            ruabox.Size = new Size(100, 23);
            ruabox.TabIndex = 13;
            // 
            // compbox
            // 
            compbox.Location = new Point(264, 69);
            compbox.Name = "compbox";
            compbox.Size = new Size(100, 23);
            compbox.TabIndex = 14;
            // 
            // rua
            // 
            rua.AutoSize = true;
            rua.Location = new Point(178, 115);
            rua.Name = "rua";
            rua.Size = new Size(0, 15);
            rua.TabIndex = 7;
            // 
            // numerobox
            // 
            numerobox.Location = new Point(264, 115);
            numerobox.Name = "numerobox";
            numerobox.Size = new Size(100, 23);
            numerobox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 123);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 15;
            label1.Text = "numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 165);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 16;
            label2.Text = "endereço";
            // 
            // enderecobox
            // 
            enderecobox.Location = new Point(269, 165);
            enderecobox.Name = "enderecobox";
            enderecobox.Size = new Size(95, 23);
            enderecobox.TabIndex = 17;
            // 
            // perfiluser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(enderecobox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(compbox);
            Controls.Add(ruabox);
            Controls.Add(telefonebox);
            Controls.Add(cepbox);
            Controls.Add(numerobox);
            Controls.Add(nomebox);
            Controls.Add(usuariobox);
            Controls.Add(rua);
            Controls.Add(label6);
            Controls.Add(ln);
            Controls.Add(xd);
            Controls.Add(aq);
            Controls.Add(se);
            Controls.Add(bv);
            Name = "perfiluser";
            Text = "perfiluser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bv;
        private Label se;
        private Label aq;
        private Label xd;
        private Label ln;
        private Label label6;
        private TextBox usuariobox;
        private TextBox nomebox;
        private TextBox cepbox;
        private TextBox telefonebox;
        private TextBox ruabox;
        private TextBox compbox;
        private Label rua;
        private TextBox numerobox;
        private Label label1;
        private Label label2;
        private TextBox enderecobox;
    }
}
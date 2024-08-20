namespace combo_box___PrincipaisPropriedades
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.Inserir = new System.Windows.Forms.Button();
            this.Ordenar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.cboLista = new System.Windows.Forms.ComboBox();
            this.lblQtde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade de Itens:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Índice do Combo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Texto do Combo:";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(173, 56);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(452, 20);
            this.txtTexto.TabIndex = 5;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(228, 297);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(410, 20);
            this.txtindice.TabIndex = 6;
            this.txtindice.TextChanged += new System.EventHandler(this.txtindice_TextChanged);
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(228, 344);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(413, 20);
            this.txtConteudo.TabIndex = 7;
            // 
            // Inserir
            // 
            this.Inserir.Location = new System.Drawing.Point(228, 101);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(111, 36);
            this.Inserir.TabIndex = 8;
            this.Inserir.Text = "Inserir no Combo";
            this.Inserir.UseVisualStyleBackColor = true;
            this.Inserir.Click += new System.EventHandler(this.Inserir_Click);
            // 
            // Ordenar
            // 
            this.Ordenar.Location = new System.Drawing.Point(396, 102);
            this.Ordenar.Name = "Ordenar";
            this.Ordenar.Size = new System.Drawing.Size(138, 34);
            this.Ordenar.TabIndex = 9;
            this.Ordenar.Text = "Ordenar o Combo";
            this.Ordenar.UseVisualStyleBackColor = true;
            this.Ordenar.Click += new System.EventHandler(this.Ordenar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(355, 185);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(119, 36);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "Remover do Combo";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(322, 248);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(178, 32);
            this.btnExibir.TabIndex = 11;
            this.btnExibir.Text = "Exibir dados do Combo";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // cboLista
            // 
            this.cboLista.FormattingEnabled = true;
            this.cboLista.Location = new System.Drawing.Point(163, 152);
            this.cboLista.Name = "cboLista";
            this.cboLista.Size = new System.Drawing.Size(475, 21);
            this.cboLista.TabIndex = 12;
            this.cboLista.SelectedIndexChanged += new System.EventHandler(this.cboLista_SelectedIndexChanged);
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Location = new System.Drawing.Point(255, 228);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(0, 13);
            this.lblQtde.TabIndex = 13;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(829, 407);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.cboLista);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.Ordenar);
            this.Controls.Add(this.Inserir);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Button Inserir;
        private System.Windows.Forms.Button Ordenar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.ComboBox cboLista;
        private System.Windows.Forms.Label lblQtde;
    }
}


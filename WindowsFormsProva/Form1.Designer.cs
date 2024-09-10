namespace WindowsFormsProva
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
            this.vendas = new System.Windows.Forms.Label();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtqntd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btninserir = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtalterar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnalterar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venda:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Unitário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade:";
            // 
            // vendas
            // 
            this.vendas.AutoSize = true;
            this.vendas.ForeColor = System.Drawing.Color.Red;
            this.vendas.Location = new System.Drawing.Point(113, 21);
            this.vendas.Name = "vendas";
            this.vendas.Size = new System.Drawing.Size(13, 13);
            this.vendas.TabIndex = 3;
            this.vendas.Text = "1";
            this.vendas.Click += new System.EventHandler(this.vendas_Click);
            // 
            // txtproduto
            // 
            this.txtproduto.Location = new System.Drawing.Point(170, 60);
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(477, 20);
            this.txtproduto.TabIndex = 4;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(170, 154);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(119, 20);
            this.txtvalor.TabIndex = 5;
            // 
            // txtqntd
            // 
            this.txtqntd.Location = new System.Drawing.Point(170, 106);
            this.txtqntd.Name = "txtqntd";
            this.txtqntd.Size = new System.Drawing.Size(119, 20);
            this.txtqntd.TabIndex = 6;
            this.txtqntd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Produto:";
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(341, 134);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(132, 59);
            this.btninserir.TabIndex = 8;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // btnremover
            // 
            this.btnremover.Location = new System.Drawing.Point(515, 134);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(132, 59);
            this.btnremover.TabIndex = 9;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produto,
            this.quantidade,
            this.valor});
            this.dgv.Location = new System.Drawing.Point(181, 218);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(466, 166);
            this.dgv.TabIndex = 10;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // produto
            // 
            this.produto.HeaderText = "PRODUTO";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "QUANTIDADE";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.HeaderText = "V.UNITÁRIO";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // txtalterar
            // 
            this.txtalterar.Location = new System.Drawing.Point(273, 426);
            this.txtalterar.Name = "txtalterar";
            this.txtalterar.Size = new System.Drawing.Size(119, 20);
            this.txtalterar.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Alterar Quantidade do item Selecionado:";
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(431, 426);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(132, 20);
            this.btnalterar.TabIndex = 13;
            this.btnalterar.Text = "Alterar Quantidade";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total da Venda:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbltotal.Location = new System.Drawing.Point(196, 479);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(13, 13);
            this.lbltotal.TabIndex = 15;
            this.lbltotal.Text = "1";
            this.lbltotal.Click += new System.EventHandler(this.lbltotal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(169, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "R$";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(77, 515);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(132, 59);
            this.btnguardar.TabIndex = 17;
            this.btnguardar.Text = "Gravar Venda";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(260, 515);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(132, 59);
            this.btncancelar.TabIndex = 18;
            this.btncancelar.Text = "Cancelar Venda";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(431, 515);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(132, 59);
            this.btnfechar.TabIndex = 19;
            this.btnfechar.Text = "Finalizr Sistema";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 598);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.txtalterar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtqntd);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtproduto);
            this.Controls.Add(this.vendas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label vendas;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtqntd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.TextBox txtalterar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnfechar;
    }
}


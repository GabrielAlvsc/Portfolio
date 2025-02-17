
namespace Tfinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Clientes = new System.Windows.Forms.TabPage();
            this.bcl_save = new System.Windows.Forms.Button();
            this.bcl_delete = new System.Windows.Forms.Button();
            this.bcl_update = new System.Windows.Forms.Button();
            this.bcl_insert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcl_s = new System.Windows.Forms.TextBox();
            this.txtcl_n = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.Produtos = new System.Windows.Forms.TabPage();
            this.bp_save = new System.Windows.Forms.Button();
            this.bp_delete = new System.Windows.Forms.Button();
            this.bp_update = new System.Windows.Forms.Button();
            this.bp_insert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpr_d = new System.Windows.Forms.TextBox();
            this.txtpr_p = new System.Windows.Forms.TextBox();
            this.txtpr_n = new System.Windows.Forms.TextBox();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.Compras = new System.Windows.Forms.TabPage();
            this.bco_save = new System.Windows.Forms.Button();
            this.bco_delete = new System.Windows.Forms.Button();
            this.bco_update = new System.Windows.Forms.Button();
            this.bco_insert = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtco_q = new System.Windows.Forms.TextBox();
            this.cbco_p = new System.Windows.Forms.ComboBox();
            this.cbco_n = new System.Windows.Forms.ComboBox();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.Produtos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.Compras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Clientes);
            this.tabControl1.Controls.Add(this.Produtos);
            this.tabControl1.Controls.Add(this.Compras);
            this.tabControl1.Location = new System.Drawing.Point(-5, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1192, 524);
            this.tabControl1.TabIndex = 0;
            // 
            // Clientes
            // 
            this.Clientes.Controls.Add(this.bcl_save);
            this.Clientes.Controls.Add(this.bcl_delete);
            this.Clientes.Controls.Add(this.bcl_update);
            this.Clientes.Controls.Add(this.bcl_insert);
            this.Clientes.Controls.Add(this.label2);
            this.Clientes.Controls.Add(this.label1);
            this.Clientes.Controls.Add(this.txtcl_s);
            this.Clientes.Controls.Add(this.txtcl_n);
            this.Clientes.Controls.Add(this.dgvCliente);
            this.Clientes.Location = new System.Drawing.Point(4, 29);
            this.Clientes.Name = "Clientes";
            this.Clientes.Padding = new System.Windows.Forms.Padding(3);
            this.Clientes.Size = new System.Drawing.Size(1184, 491);
            this.Clientes.TabIndex = 0;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = true;
            // 
            // bcl_save
            // 
            this.bcl_save.Location = new System.Drawing.Point(1038, 86);
            this.bcl_save.Name = "bcl_save";
            this.bcl_save.Size = new System.Drawing.Size(94, 29);
            this.bcl_save.TabIndex = 8;
            this.bcl_save.Text = "Salvar";
            this.bcl_save.UseVisualStyleBackColor = true;
            this.bcl_save.Click += new System.EventHandler(this.bcl_save_Click);
            // 
            // bcl_delete
            // 
            this.bcl_delete.Location = new System.Drawing.Point(1038, 27);
            this.bcl_delete.Name = "bcl_delete";
            this.bcl_delete.Size = new System.Drawing.Size(94, 29);
            this.bcl_delete.TabIndex = 7;
            this.bcl_delete.Text = "Deletar";
            this.bcl_delete.UseVisualStyleBackColor = true;
            this.bcl_delete.Click += new System.EventHandler(this.bcl_delete_Click);
            // 
            // bcl_update
            // 
            this.bcl_update.Location = new System.Drawing.Point(911, 86);
            this.bcl_update.Name = "bcl_update";
            this.bcl_update.Size = new System.Drawing.Size(94, 29);
            this.bcl_update.TabIndex = 6;
            this.bcl_update.Text = "Atualizar";
            this.bcl_update.UseVisualStyleBackColor = true;
            this.bcl_update.Click += new System.EventHandler(this.bcl_update_Click);
            // 
            // bcl_insert
            // 
            this.bcl_insert.Location = new System.Drawing.Point(911, 27);
            this.bcl_insert.Name = "bcl_insert";
            this.bcl_insert.Size = new System.Drawing.Size(94, 29);
            this.bcl_insert.TabIndex = 5;
            this.bcl_insert.Text = "Inserir";
            this.bcl_insert.UseVisualStyleBackColor = true;
            this.bcl_insert.Click += new System.EventHandler(this.bcl_insert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sobrenome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // txtcl_s
            // 
            this.txtcl_s.Location = new System.Drawing.Point(45, 86);
            this.txtcl_s.Name = "txtcl_s";
            this.txtcl_s.Size = new System.Drawing.Size(413, 27);
            this.txtcl_s.TabIndex = 2;
            // 
            // txtcl_n
            // 
            this.txtcl_n.Location = new System.Drawing.Point(45, 27);
            this.txtcl_n.Name = "txtcl_n";
            this.txtcl_n.Size = new System.Drawing.Size(413, 27);
            this.txtcl_n.TabIndex = 1;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(6, 155);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.RowTemplate.Height = 29;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(1172, 330);
            this.dgvCliente.TabIndex = 0;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // Produtos
            // 
            this.Produtos.Controls.Add(this.bp_save);
            this.Produtos.Controls.Add(this.bp_delete);
            this.Produtos.Controls.Add(this.bp_update);
            this.Produtos.Controls.Add(this.bp_insert);
            this.Produtos.Controls.Add(this.label5);
            this.Produtos.Controls.Add(this.label4);
            this.Produtos.Controls.Add(this.label3);
            this.Produtos.Controls.Add(this.txtpr_d);
            this.Produtos.Controls.Add(this.txtpr_p);
            this.Produtos.Controls.Add(this.txtpr_n);
            this.Produtos.Controls.Add(this.dgvProduto);
            this.Produtos.Location = new System.Drawing.Point(4, 29);
            this.Produtos.Name = "Produtos";
            this.Produtos.Padding = new System.Windows.Forms.Padding(3);
            this.Produtos.Size = new System.Drawing.Size(1184, 491);
            this.Produtos.TabIndex = 1;
            this.Produtos.Text = "Produtos";
            this.Produtos.UseVisualStyleBackColor = true;
            // 
            // bp_save
            // 
            this.bp_save.Location = new System.Drawing.Point(1038, 86);
            this.bp_save.Name = "bp_save";
            this.bp_save.Size = new System.Drawing.Size(94, 29);
            this.bp_save.TabIndex = 12;
            this.bp_save.Text = "Salvar";
            this.bp_save.UseVisualStyleBackColor = true;
            this.bp_save.Click += new System.EventHandler(this.bp_save_Click);
            // 
            // bp_delete
            // 
            this.bp_delete.Location = new System.Drawing.Point(1038, 27);
            this.bp_delete.Name = "bp_delete";
            this.bp_delete.Size = new System.Drawing.Size(94, 29);
            this.bp_delete.TabIndex = 11;
            this.bp_delete.Text = "Deletar";
            this.bp_delete.UseVisualStyleBackColor = true;
            this.bp_delete.Click += new System.EventHandler(this.bp_delete_Click);
            // 
            // bp_update
            // 
            this.bp_update.Location = new System.Drawing.Point(911, 86);
            this.bp_update.Name = "bp_update";
            this.bp_update.Size = new System.Drawing.Size(94, 29);
            this.bp_update.TabIndex = 10;
            this.bp_update.Text = "Atualizar";
            this.bp_update.UseVisualStyleBackColor = true;
            this.bp_update.Click += new System.EventHandler(this.bp_update_Click);
            // 
            // bp_insert
            // 
            this.bp_insert.Location = new System.Drawing.Point(911, 27);
            this.bp_insert.Name = "bp_insert";
            this.bp_insert.Size = new System.Drawing.Size(94, 29);
            this.bp_insert.TabIndex = 9;
            this.bp_insert.Text = "Inserir";
            this.bp_insert.UseVisualStyleBackColor = true;
            this.bp_insert.Click += new System.EventHandler(this.bp_insert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Descricao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Produto";
            // 
            // txtpr_d
            // 
            this.txtpr_d.Location = new System.Drawing.Point(480, 27);
            this.txtpr_d.Name = "txtpr_d";
            this.txtpr_d.Size = new System.Drawing.Size(413, 27);
            this.txtpr_d.TabIndex = 3;
            // 
            // txtpr_p
            // 
            this.txtpr_p.Location = new System.Drawing.Point(45, 86);
            this.txtpr_p.Name = "txtpr_p";
            this.txtpr_p.Size = new System.Drawing.Size(413, 27);
            this.txtpr_p.TabIndex = 2;
            // 
            // txtpr_n
            // 
            this.txtpr_n.Location = new System.Drawing.Point(45, 27);
            this.txtpr_n.Name = "txtpr_n";
            this.txtpr_n.Size = new System.Drawing.Size(413, 27);
            this.txtpr_n.TabIndex = 1;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(6, 155);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.RowHeadersWidth = 51;
            this.dgvProduto.RowTemplate.Height = 29;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(1172, 330);
            this.dgvProduto.TabIndex = 0;
            this.dgvProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellContentClick);
            // 
            // Compras
            // 
            this.Compras.Controls.Add(this.bco_save);
            this.Compras.Controls.Add(this.bco_delete);
            this.Compras.Controls.Add(this.bco_update);
            this.Compras.Controls.Add(this.bco_insert);
            this.Compras.Controls.Add(this.label9);
            this.Compras.Controls.Add(this.label8);
            this.Compras.Controls.Add(this.label7);
            this.Compras.Controls.Add(this.txtco_q);
            this.Compras.Controls.Add(this.cbco_p);
            this.Compras.Controls.Add(this.cbco_n);
            this.Compras.Controls.Add(this.dgvCompra);
            this.Compras.Location = new System.Drawing.Point(4, 29);
            this.Compras.Name = "Compras";
            this.Compras.Size = new System.Drawing.Size(1184, 491);
            this.Compras.TabIndex = 2;
            this.Compras.Text = "Compras";
            this.Compras.UseVisualStyleBackColor = true;
            // 
            // bco_save
            // 
            this.bco_save.Location = new System.Drawing.Point(1038, 86);
            this.bco_save.Name = "bco_save";
            this.bco_save.Size = new System.Drawing.Size(94, 29);
            this.bco_save.TabIndex = 10;
            this.bco_save.Text = "Salvar";
            this.bco_save.UseVisualStyleBackColor = true;
            this.bco_save.Click += new System.EventHandler(this.bco_save_Click);
            // 
            // bco_delete
            // 
            this.bco_delete.Location = new System.Drawing.Point(1038, 27);
            this.bco_delete.Name = "bco_delete";
            this.bco_delete.Size = new System.Drawing.Size(94, 29);
            this.bco_delete.TabIndex = 9;
            this.bco_delete.Text = "Deletar";
            this.bco_delete.UseVisualStyleBackColor = true;
            this.bco_delete.Click += new System.EventHandler(this.bco_delete_Click);
            // 
            // bco_update
            // 
            this.bco_update.Location = new System.Drawing.Point(911, 86);
            this.bco_update.Name = "bco_update";
            this.bco_update.Size = new System.Drawing.Size(94, 29);
            this.bco_update.TabIndex = 8;
            this.bco_update.Text = "Atualizar";
            this.bco_update.UseVisualStyleBackColor = true;
            this.bco_update.Click += new System.EventHandler(this.bco_update_Click);
            // 
            // bco_insert
            // 
            this.bco_insert.Location = new System.Drawing.Point(911, 27);
            this.bco_insert.Name = "bco_insert";
            this.bco_insert.Size = new System.Drawing.Size(94, 29);
            this.bco_insert.TabIndex = 7;
            this.bco_insert.Text = "Inserir";
            this.bco_insert.UseVisualStyleBackColor = true;
            this.bco_insert.Click += new System.EventHandler(this.bco_insert_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(480, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Quantidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Produto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cliente";
            // 
            // txtco_q
            // 
            this.txtco_q.Location = new System.Drawing.Point(480, 27);
            this.txtco_q.Name = "txtco_q";
            this.txtco_q.Size = new System.Drawing.Size(413, 27);
            this.txtco_q.TabIndex = 3;
            // 
            // cbco_p
            // 
            this.cbco_p.FormattingEnabled = true;
            this.cbco_p.Location = new System.Drawing.Point(45, 86);
            this.cbco_p.Name = "cbco_p";
            this.cbco_p.Size = new System.Drawing.Size(413, 28);
            this.cbco_p.TabIndex = 2;
            // 
            // cbco_n
            // 
            this.cbco_n.FormattingEnabled = true;
            this.cbco_n.Location = new System.Drawing.Point(45, 27);
            this.cbco_n.Name = "cbco_n";
            this.cbco_n.Size = new System.Drawing.Size(413, 28);
            this.cbco_n.TabIndex = 1;
            // 
            // dgvCompra
            // 
            this.dgvCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Location = new System.Drawing.Point(6, 155);
            this.dgvCompra.MultiSelect = false;
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.RowHeadersWidth = 51;
            this.dgvCompra.RowTemplate.Height = 29;
            this.dgvCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompra.Size = new System.Drawing.Size(1172, 330);
            this.dgvCompra.TabIndex = 0;
            this.dgvCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompra_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 524);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supermercado Pitomba";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Clientes.ResumeLayout(false);
            this.Clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.Produtos.ResumeLayout(false);
            this.Produtos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.Compras.ResumeLayout(false);
            this.Compras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Clientes;
        private System.Windows.Forms.TabPage Produtos;
        private System.Windows.Forms.TabPage Compras;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcl_s;
        private System.Windows.Forms.TextBox txtcl_n;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpr_d;
        private System.Windows.Forms.TextBox txtpr_p;
        private System.Windows.Forms.TextBox txtpr_n;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtco_q;
        private System.Windows.Forms.ComboBox cbco_p;
        private System.Windows.Forms.ComboBox cbco_n;
        private System.Windows.Forms.Button bcl_save;
        private System.Windows.Forms.Button bcl_delete;
        private System.Windows.Forms.Button bcl_update;
        private System.Windows.Forms.Button bcl_insert;
        private System.Windows.Forms.Button bp_save;
        private System.Windows.Forms.Button bp_delete;
        private System.Windows.Forms.Button bp_update;
        private System.Windows.Forms.Button bp_insert;
        private System.Windows.Forms.Button bco_save;
        private System.Windows.Forms.Button bco_delete;
        private System.Windows.Forms.Button bco_update;
        private System.Windows.Forms.Button bco_insert;
    }
}


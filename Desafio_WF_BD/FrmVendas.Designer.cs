namespace Desafio_WF_BD
{
    partial class FrmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_IdVendas = new System.Windows.Forms.Label();
            this.lbl_IdCliente = new System.Windows.Forms.Label();
            this.lbl_ValorTotal = new System.Windows.Forms.Label();
            this.tb_IdVendas = new System.Windows.Forms.TextBox();
            this.tb_IdCliente = new System.Windows.Forms.TextBox();
            this.tb_ValorTotal = new System.Windows.Forms.TextBox();
            this.btn_EfetuarVenda = new System.Windows.Forms.Button();
            this.dgv_Vendas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.bt_Limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vendas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1015, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_IdVendas
            // 
            this.lbl_IdVendas.AutoSize = true;
            this.lbl_IdVendas.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdVendas.Location = new System.Drawing.Point(203, 55);
            this.lbl_IdVendas.Name = "lbl_IdVendas";
            this.lbl_IdVendas.Size = new System.Drawing.Size(62, 15);
            this.lbl_IdVendas.TabIndex = 2;
            this.lbl_IdVendas.Text = "Id Venda:";
            // 
            // lbl_IdCliente
            // 
            this.lbl_IdCliente.AutoSize = true;
            this.lbl_IdCliente.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdCliente.Location = new System.Drawing.Point(203, 99);
            this.lbl_IdCliente.Name = "lbl_IdCliente";
            this.lbl_IdCliente.Size = new System.Drawing.Size(65, 15);
            this.lbl_IdCliente.TabIndex = 3;
            this.lbl_IdCliente.Text = "Id Cliente:";
            // 
            // lbl_ValorTotal
            // 
            this.lbl_ValorTotal.AutoSize = true;
            this.lbl_ValorTotal.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorTotal.Location = new System.Drawing.Point(203, 147);
            this.lbl_ValorTotal.Name = "lbl_ValorTotal";
            this.lbl_ValorTotal.Size = new System.Drawing.Size(80, 15);
            this.lbl_ValorTotal.TabIndex = 4;
            this.lbl_ValorTotal.Text = "Valor Total: ";
            // 
            // tb_IdVendas
            // 
            this.tb_IdVendas.Location = new System.Drawing.Point(299, 48);
            this.tb_IdVendas.Name = "tb_IdVendas";
            this.tb_IdVendas.Size = new System.Drawing.Size(100, 22);
            this.tb_IdVendas.TabIndex = 5;
            // 
            // tb_IdCliente
            // 
            this.tb_IdCliente.Location = new System.Drawing.Point(299, 92);
            this.tb_IdCliente.Name = "tb_IdCliente";
            this.tb_IdCliente.Size = new System.Drawing.Size(100, 22);
            this.tb_IdCliente.TabIndex = 6;
            // 
            // tb_ValorTotal
            // 
            this.tb_ValorTotal.Location = new System.Drawing.Point(299, 140);
            this.tb_ValorTotal.Name = "tb_ValorTotal";
            this.tb_ValorTotal.Size = new System.Drawing.Size(100, 22);
            this.tb_ValorTotal.TabIndex = 7;
            // 
            // btn_EfetuarVenda
            // 
            this.btn_EfetuarVenda.Font = new System.Drawing.Font("Lucida Sans", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EfetuarVenda.Location = new System.Drawing.Point(180, 215);
            this.btn_EfetuarVenda.Name = "btn_EfetuarVenda";
            this.btn_EfetuarVenda.Size = new System.Drawing.Size(114, 35);
            this.btn_EfetuarVenda.TabIndex = 8;
            this.btn_EfetuarVenda.Text = "Efetuar Venda";
            this.btn_EfetuarVenda.UseVisualStyleBackColor = true;
            this.btn_EfetuarVenda.Click += new System.EventHandler(this.btn_EfetuarVenda_Click);
            // 
            // dgv_Vendas
            // 
            this.dgv_Vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_Vendas.Enabled = false;
            this.dgv_Vendas.Location = new System.Drawing.Point(504, 48);
            this.dgv_Vendas.Name = "dgv_Vendas";
            this.dgv_Vendas.RowHeadersWidth = 51;
            this.dgv_Vendas.RowTemplate.Height = 24;
            this.dgv_Vendas.Size = new System.Drawing.Size(302, 160);
            this.dgv_Vendas.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Venda";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id Cliente";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Valor Total";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 90;
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_Fechar.Font = new System.Drawing.Font("Lucida Sans", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Fechar.Location = new System.Drawing.Point(815, 288);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(115, 54);
            this.bt_Fechar.TabIndex = 11;
            this.bt_Fechar.Text = "Fechar";
            this.bt_Fechar.UseVisualStyleBackColor = false;
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Font = new System.Drawing.Font("Lucida Sans", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Limpar.Location = new System.Drawing.Point(313, 215);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(114, 35);
            this.bt_Limpar.TabIndex = 12;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 380);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.bt_Fechar);
            this.Controls.Add(this.dgv_Vendas);
            this.Controls.Add(this.btn_EfetuarVenda);
            this.Controls.Add(this.tb_ValorTotal);
            this.Controls.Add(this.tb_IdCliente);
            this.Controls.Add(this.tb_IdVendas);
            this.Controls.Add(this.lbl_ValorTotal);
            this.Controls.Add(this.lbl_IdCliente);
            this.Controls.Add(this.lbl_IdVendas);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmVendas";
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_IdVendas;
        private System.Windows.Forms.Label lbl_IdCliente;
        private System.Windows.Forms.Label lbl_ValorTotal;
        private System.Windows.Forms.TextBox tb_IdVendas;
        private System.Windows.Forms.TextBox tb_IdCliente;
        private System.Windows.Forms.TextBox tb_ValorTotal;
        private System.Windows.Forms.Button btn_EfetuarVenda;
        private System.Windows.Forms.DataGridView dgv_Vendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.Button bt_Limpar;
    }
}
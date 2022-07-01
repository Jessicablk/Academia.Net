namespace Desafio_WF_BD
{
    partial class FrmItensVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItensVendas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_TotalVendas = new System.Windows.Forms.TextBox();
            this.tb_Qntdd = new System.Windows.Forms.TextBox();
            this.tb_ValorUni = new System.Windows.Forms.TextBox();
            this.tb_IdProduto = new System.Windows.Forms.TextBox();
            this.lbl_TotalVendas = new System.Windows.Forms.Label();
            this.lbl_Qntdd = new System.Windows.Forms.Label();
            this.lbl_ValorUn = new System.Windows.Forms.Label();
            this.lbl_IdProduto = new System.Windows.Forms.Label();
            this.dgv_ItensVendas = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_GravarVenda = new System.Windows.Forms.Button();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.bt_Limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItensVendas)).BeginInit();
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
            // tb_TotalVendas
            // 
            this.tb_TotalVendas.Location = new System.Drawing.Point(281, 175);
            this.tb_TotalVendas.Name = "tb_TotalVendas";
            this.tb_TotalVendas.Size = new System.Drawing.Size(100, 22);
            this.tb_TotalVendas.TabIndex = 38;
            // 
            // tb_Qntdd
            // 
            this.tb_Qntdd.Location = new System.Drawing.Point(281, 150);
            this.tb_Qntdd.Name = "tb_Qntdd";
            this.tb_Qntdd.Size = new System.Drawing.Size(100, 22);
            this.tb_Qntdd.TabIndex = 37;
            // 
            // tb_ValorUni
            // 
            this.tb_ValorUni.Location = new System.Drawing.Point(281, 124);
            this.tb_ValorUni.Name = "tb_ValorUni";
            this.tb_ValorUni.Size = new System.Drawing.Size(100, 22);
            this.tb_ValorUni.TabIndex = 36;
            // 
            // tb_IdProduto
            // 
            this.tb_IdProduto.Location = new System.Drawing.Point(281, 97);
            this.tb_IdProduto.Name = "tb_IdProduto";
            this.tb_IdProduto.Size = new System.Drawing.Size(100, 22);
            this.tb_IdProduto.TabIndex = 35;
            // 
            // lbl_TotalVendas
            // 
            this.lbl_TotalVendas.AutoSize = true;
            this.lbl_TotalVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_TotalVendas.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalVendas.Location = new System.Drawing.Point(148, 182);
            this.lbl_TotalVendas.Name = "lbl_TotalVendas";
            this.lbl_TotalVendas.Size = new System.Drawing.Size(106, 15);
            this.lbl_TotalVendas.TabIndex = 32;
            this.lbl_TotalVendas.Text = "Total de Vendas:";
            // 
            // lbl_Qntdd
            // 
            this.lbl_Qntdd.AutoSize = true;
            this.lbl_Qntdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Qntdd.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qntdd.Location = new System.Drawing.Point(148, 157);
            this.lbl_Qntdd.Name = "lbl_Qntdd";
            this.lbl_Qntdd.Size = new System.Drawing.Size(77, 15);
            this.lbl_Qntdd.TabIndex = 31;
            this.lbl_Qntdd.Text = "Quantidade:";
            // 
            // lbl_ValorUn
            // 
            this.lbl_ValorUn.AutoSize = true;
            this.lbl_ValorUn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_ValorUn.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorUn.Location = new System.Drawing.Point(148, 131);
            this.lbl_ValorUn.Name = "lbl_ValorUn";
            this.lbl_ValorUn.Size = new System.Drawing.Size(91, 15);
            this.lbl_ValorUn.TabIndex = 30;
            this.lbl_ValorUn.Text = "Valor Unitário:";
            // 
            // lbl_IdProduto
            // 
            this.lbl_IdProduto.AutoSize = true;
            this.lbl_IdProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_IdProduto.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdProduto.Location = new System.Drawing.Point(148, 104);
            this.lbl_IdProduto.Name = "lbl_IdProduto";
            this.lbl_IdProduto.Size = new System.Drawing.Size(70, 15);
            this.lbl_IdProduto.TabIndex = 29;
            this.lbl_IdProduto.Text = "Id Produto:";
            // 
            // dgv_ItensVendas
            // 
            this.dgv_ItensVendas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_ItensVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ItensVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_ItensVendas.Enabled = false;
            this.dgv_ItensVendas.Location = new System.Drawing.Point(445, 59);
            this.dgv_ItensVendas.Name = "dgv_ItensVendas";
            this.dgv_ItensVendas.RowHeadersWidth = 51;
            this.dgv_ItensVendas.RowTemplate.Height = 24;
            this.dgv_ItensVendas.Size = new System.Drawing.Size(327, 214);
            this.dgv_ItensVendas.TabIndex = 26;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id Produto";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Valor Unitário";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quantidade";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 90;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total de Vendas";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 65;
            // 
            // btn_GravarVenda
            // 
            this.btn_GravarVenda.Font = new System.Drawing.Font("Lucida Sans", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GravarVenda.Location = new System.Drawing.Point(139, 225);
            this.btn_GravarVenda.Name = "btn_GravarVenda";
            this.btn_GravarVenda.Size = new System.Drawing.Size(115, 48);
            this.btn_GravarVenda.TabIndex = 39;
            this.btn_GravarVenda.Text = "Gravar Venda";
            this.btn_GravarVenda.UseVisualStyleBackColor = true;
            this.btn_GravarVenda.Click += new System.EventHandler(this.btn_GravarVenda_Click);
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_Fechar.Font = new System.Drawing.Font("Lucida Sans", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Fechar.Location = new System.Drawing.Point(887, 293);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(88, 60);
            this.bt_Fechar.TabIndex = 41;
            this.bt_Fechar.Text = "Fechar";
            this.bt_Fechar.UseVisualStyleBackColor = false;
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Font = new System.Drawing.Font("Lucida Sans", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Limpar.Location = new System.Drawing.Point(266, 225);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(115, 48);
            this.bt_Limpar.TabIndex = 42;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // FrmItensVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 380);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.bt_Fechar);
            this.Controls.Add(this.btn_GravarVenda);
            this.Controls.Add(this.tb_TotalVendas);
            this.Controls.Add(this.tb_Qntdd);
            this.Controls.Add(this.tb_ValorUni);
            this.Controls.Add(this.tb_IdProduto);
            this.Controls.Add(this.lbl_TotalVendas);
            this.Controls.Add(this.lbl_Qntdd);
            this.Controls.Add(this.lbl_ValorUn);
            this.Controls.Add(this.lbl_IdProduto);
            this.Controls.Add(this.dgv_ItensVendas);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmItensVendas";
            this.Text = "ItensVendas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItensVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_TotalVendas;
        private System.Windows.Forms.TextBox tb_Qntdd;
        private System.Windows.Forms.TextBox tb_ValorUni;
        private System.Windows.Forms.TextBox tb_IdProduto;
        private System.Windows.Forms.Label lbl_TotalVendas;
        private System.Windows.Forms.Label lbl_Qntdd;
        private System.Windows.Forms.Label lbl_ValorUn;
        private System.Windows.Forms.Label lbl_IdProduto;
        private System.Windows.Forms.DataGridView dgv_ItensVendas;
        private System.Windows.Forms.Button btn_GravarVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.Button bt_Limpar;
    }
}
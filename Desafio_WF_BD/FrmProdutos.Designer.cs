namespace Desafio_WF_BD
{
    partial class FrmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_Produtos = new System.Windows.Forms.DataGridView();
            this.CodEAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.tb_ValorProduto = new System.Windows.Forms.TextBox();
            this.tb_Estoque = new System.Windows.Forms.TextBox();
            this.tb_NomeProduto = new System.Windows.Forms.TextBox();
            this.tb_CodEAN = new System.Windows.Forms.TextBox();
            this.lbl_ValorProduto = new System.Windows.Forms.Label();
            this.lbl_Estoque = new System.Windows.Forms.Label();
            this.lbl_NomeProduto = new System.Windows.Forms.Label();
            this.lbl_CodEAN = new System.Windows.Forms.Label();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.bt_Limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produtos)).BeginInit();
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
            // dgv_Produtos
            // 
            this.dgv_Produtos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodEAN,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_Produtos.Enabled = false;
            this.dgv_Produtos.Location = new System.Drawing.Point(397, 37);
            this.dgv_Produtos.Name = "dgv_Produtos";
            this.dgv_Produtos.RowHeadersWidth = 51;
            this.dgv_Produtos.RowTemplate.Height = 24;
            this.dgv_Produtos.Size = new System.Drawing.Size(418, 270);
            this.dgv_Produtos.TabIndex = 23;
            // 
            // CodEAN
            // 
            this.CodEAN.HeaderText = "CodEAN";
            this.CodEAN.MinimumWidth = 6;
            this.CodEAN.Name = "CodEAN";
            this.CodEAN.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome do Produto";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Estoque";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Valor do Produto";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Font = new System.Drawing.Font("Lucida Sans", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inserir.Location = new System.Drawing.Point(133, 203);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(85, 49);
            this.btn_Inserir.TabIndex = 21;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // tb_ValorProduto
            // 
            this.tb_ValorProduto.Location = new System.Drawing.Point(229, 129);
            this.tb_ValorProduto.Name = "tb_ValorProduto";
            this.tb_ValorProduto.Size = new System.Drawing.Size(145, 22);
            this.tb_ValorProduto.TabIndex = 20;
            // 
            // tb_Estoque
            // 
            this.tb_Estoque.Location = new System.Drawing.Point(229, 104);
            this.tb_Estoque.Name = "tb_Estoque";
            this.tb_Estoque.Size = new System.Drawing.Size(145, 22);
            this.tb_Estoque.TabIndex = 19;
            // 
            // tb_NomeProduto
            // 
            this.tb_NomeProduto.Location = new System.Drawing.Point(229, 79);
            this.tb_NomeProduto.Name = "tb_NomeProduto";
            this.tb_NomeProduto.Size = new System.Drawing.Size(145, 22);
            this.tb_NomeProduto.TabIndex = 18;
            // 
            // tb_CodEAN
            // 
            this.tb_CodEAN.Location = new System.Drawing.Point(229, 54);
            this.tb_CodEAN.Name = "tb_CodEAN";
            this.tb_CodEAN.Size = new System.Drawing.Size(145, 22);
            this.tb_CodEAN.TabIndex = 17;
            // 
            // lbl_ValorProduto
            // 
            this.lbl_ValorProduto.AutoSize = true;
            this.lbl_ValorProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_ValorProduto.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorProduto.Location = new System.Drawing.Point(86, 136);
            this.lbl_ValorProduto.Name = "lbl_ValorProduto";
            this.lbl_ValorProduto.Size = new System.Drawing.Size(110, 15);
            this.lbl_ValorProduto.TabIndex = 16;
            this.lbl_ValorProduto.Text = "Volar do Produto:";
            // 
            // lbl_Estoque
            // 
            this.lbl_Estoque.AutoSize = true;
            this.lbl_Estoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Estoque.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estoque.Location = new System.Drawing.Point(86, 111);
            this.lbl_Estoque.Name = "lbl_Estoque";
            this.lbl_Estoque.Size = new System.Drawing.Size(58, 15);
            this.lbl_Estoque.TabIndex = 15;
            this.lbl_Estoque.Text = "Estoque:";
            // 
            // lbl_NomeProduto
            // 
            this.lbl_NomeProduto.AutoSize = true;
            this.lbl_NomeProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_NomeProduto.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeProduto.Location = new System.Drawing.Point(86, 86);
            this.lbl_NomeProduto.Name = "lbl_NomeProduto";
            this.lbl_NomeProduto.Size = new System.Drawing.Size(112, 15);
            this.lbl_NomeProduto.TabIndex = 14;
            this.lbl_NomeProduto.Text = "Nome do Produto:";
            // 
            // lbl_CodEAN
            // 
            this.lbl_CodEAN.AutoSize = true;
            this.lbl_CodEAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_CodEAN.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodEAN.Location = new System.Drawing.Point(86, 61);
            this.lbl_CodEAN.Name = "lbl_CodEAN";
            this.lbl_CodEAN.Size = new System.Drawing.Size(58, 15);
            this.lbl_CodEAN.TabIndex = 13;
            this.lbl_CodEAN.Text = "CodEAN:";
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_Fechar.Font = new System.Drawing.Font("Lucida Sans", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Fechar.Location = new System.Drawing.Point(887, 293);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(88, 60);
            this.bt_Fechar.TabIndex = 24;
            this.bt_Fechar.Text = "Fechar";
            this.bt_Fechar.UseVisualStyleBackColor = false;
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Limpar.Font = new System.Drawing.Font("Lucida Sans", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Limpar.Location = new System.Drawing.Point(249, 203);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(85, 49);
            this.bt_Limpar.TabIndex = 25;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = false;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 380);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.bt_Fechar);
            this.Controls.Add(this.dgv_Produtos);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.tb_ValorProduto);
            this.Controls.Add(this.tb_Estoque);
            this.Controls.Add(this.tb_NomeProduto);
            this.Controls.Add(this.tb_CodEAN);
            this.Controls.Add(this.lbl_ValorProduto);
            this.Controls.Add(this.lbl_Estoque);
            this.Controls.Add(this.lbl_NomeProduto);
            this.Controls.Add(this.lbl_CodEAN);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmProdutos";
            this.Text = "FrmProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_Produtos;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.TextBox tb_ValorProduto;
        private System.Windows.Forms.TextBox tb_Estoque;
        private System.Windows.Forms.TextBox tb_NomeProduto;
        private System.Windows.Forms.TextBox tb_CodEAN;
        private System.Windows.Forms.Label lbl_ValorProduto;
        private System.Windows.Forms.Label lbl_Estoque;
        private System.Windows.Forms.Label lbl_NomeProduto;
        private System.Windows.Forms.Label lbl_CodEAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodEAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.Button bt_Limpar;
    }
}
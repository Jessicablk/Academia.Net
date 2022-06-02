namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variavel de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso o contrario, false.</param>
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
        /// metodo necessário para suporte ao Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTOk = new System.Windows.Forms.Button();
            this.BTCancel = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();  
            this.tbSexo = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblMSG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(110, 55);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(312, 22);
            this.tbEmail.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(27, 61);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 16);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(27, 28);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 16);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(110, 22);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(312, 22);
            this.tbNome.TabIndex = 11;
            // 
            // BTCancel
            // 
            this.BTCancel.Location = new System.Drawing.Point(292, 282);
            this.BTCancel.Name = "BTCancel";
            this.BTCancel.Size = new System.Drawing.Size(130, 40);
            this.BTCancel.TabIndex = 10;
            this.BTCancel.Text = "Cancelar";
            this.BTCancel.UseVisualStyleBackColor = true;
            this.BTCancel.Click += new System.EventHandler(this.BTCancel_Click);
            // 
            // BTOk
            // 
            this.BTOk.Location = new System.Drawing.Point(110, 282);
            this.BTOk.Name = "BTOk";
            this.BTOk.Size = new System.Drawing.Size(130, 40);
            this.BTOk.TabIndex = 9;
            this.BTOk.Text = "Ok";
            this.BTOk.UseVisualStyleBackColor = true;
            this.BTOk.Click += new System.EventHandler(this.BTOk_Click);
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.Location = new System.Drawing.Point(27, 96);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(69, 16);
            this.lblEndereço.TabIndex = 15;
            this.lblEndereço.Text = "Endereço:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(27, 231);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(67, 16);
            this.lblTelefone.TabIndex = 16;
            this.lblTelefone.Text = "Telefone: ";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(27, 130);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(46, 16);
            this.lblBairro.TabIndex = 17;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(27, 164);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(54, 16);
            this.lblCidade.TabIndex = 18;
            this.lblCidade.Text = "Cidade:";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(110, 90);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(312, 22);
            this.tbEndereco.TabIndex = 19;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(110, 225);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(312, 22);
            this.tbTelefone.TabIndex = 20;
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(110, 124);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(312, 22);
            this.tbBairro.TabIndex = 21;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(110, 158);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(312, 22);
            this.tbCidade.TabIndex = 22;
            // 
            // tbSexo
            // 
            this.tbSexo.Location = new System.Drawing.Point(110, 192);
            this.tbSexo.Name = "tbSexo";
            this.tbSexo.Size = new System.Drawing.Size(312, 22);
            this.tbSexo.TabIndex = 23;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(27, 195);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 16);
            this.lblSexo.TabIndex = 24;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblMSG
            // 
            this.lblMSG.AutoSize = true;
            this.lblMSG.Location = new System.Drawing.Point(68, 343);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(0, 16);
            this.lblMSG.TabIndex = 25;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(462, 390);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.tbSexo);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEndereço);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.BTCancel);
            this.Controls.Add(this.BTOk);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button BTCancel;
        private System.Windows.Forms.Button BTOk;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblMSG;
    }
}
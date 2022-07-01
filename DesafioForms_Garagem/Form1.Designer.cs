namespace DesafioForms_Garagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_placa = new System.Windows.Forms.Label();
            this.tb_Placa = new System.Windows.Forms.TextBox();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.bt_Saida = new System.Windows.Forms.Button();
            this.lbl_dataEntrada = new System.Windows.Forms.Label();
            this.lbl_horaEntrada = new System.Windows.Forms.Label();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.lbl_horaSaida = new System.Windows.Forms.Label();
            this.dtpHoraSaida = new System.Windows.Forms.DateTimePicker();
            this.tb_ListaEntrada = new System.Windows.Forms.TextBox();
            this.lbl_ListaEntrada = new System.Windows.Forms.Label();
            this.lbl_ListaSaida = new System.Windows.Forms.Label();
            this.tb_ListaSaida = new System.Windows.Forms.TextBox();
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.lbl_dataSaida = new System.Windows.Forms.Label();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_placa.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placa.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_placa.Location = new System.Drawing.Point(14, 12);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(54, 17);
            this.lbl_placa.TabIndex = 0;
            this.lbl_placa.Text = "Placa:";
            // 
            // tb_Placa
            // 
            this.tb_Placa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_Placa.Location = new System.Drawing.Point(87, 9);
            this.tb_Placa.Name = "tb_Placa";
            this.tb_Placa.Size = new System.Drawing.Size(112, 22);
            this.tb_Placa.TabIndex = 1;
            // 
            // bt_Cadastrar
            // 
            this.bt_Cadastrar.BackColor = System.Drawing.Color.Black;
            this.bt_Cadastrar.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cadastrar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bt_Cadastrar.Location = new System.Drawing.Point(33, 316);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(115, 67);
            this.bt_Cadastrar.TabIndex = 5;
            this.bt_Cadastrar.Text = "Cadastrar";
            this.bt_Cadastrar.UseVisualStyleBackColor = false;
            this.bt_Cadastrar.Click += new System.EventHandler(this.bt_Cadastrar_Click);
            // 
            // bt_Saida
            // 
            this.bt_Saida.BackColor = System.Drawing.Color.Black;
            this.bt_Saida.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Saida.ForeColor = System.Drawing.Color.Red;
            this.bt_Saida.Location = new System.Drawing.Point(214, 316);
            this.bt_Saida.Name = "bt_Saida";
            this.bt_Saida.Size = new System.Drawing.Size(115, 67);
            this.bt_Saida.TabIndex = 6;
            this.bt_Saida.Text = "Saída";
            this.bt_Saida.UseVisualStyleBackColor = false;
            this.bt_Saida.Click += new System.EventHandler(this.bt_Saida_Click);
            // 
            // lbl_dataEntrada
            // 
            this.lbl_dataEntrada.AutoSize = true;
            this.lbl_dataEntrada.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dataEntrada.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataEntrada.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_dataEntrada.Location = new System.Drawing.Point(15, 52);
            this.lbl_dataEntrada.Name = "lbl_dataEntrada";
            this.lbl_dataEntrada.Size = new System.Drawing.Size(139, 17);
            this.lbl_dataEntrada.TabIndex = 7;
            this.lbl_dataEntrada.Text = "Data de Entrada:";
            // 
            // lbl_horaEntrada
            // 
            this.lbl_horaEntrada.AutoSize = true;
            this.lbl_horaEntrada.BackColor = System.Drawing.Color.Transparent;
            this.lbl_horaEntrada.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horaEntrada.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_horaEntrada.Location = new System.Drawing.Point(15, 81);
            this.lbl_horaEntrada.Name = "lbl_horaEntrada";
            this.lbl_horaEntrada.Size = new System.Drawing.Size(140, 17);
            this.lbl_horaEntrada.TabIndex = 8;
            this.lbl_horaEntrada.Text = "Hora de Entrada:";
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.CalendarFont = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEntrada.Enabled = false;
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataEntrada.Location = new System.Drawing.Point(168, 47);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(123, 22);
            this.dtpDataEntrada.TabIndex = 9;
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(168, 75);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.ShowUpDown = true;
            this.dtpHoraEntrada.Size = new System.Drawing.Size(85, 22);
            this.dtpHoraEntrada.TabIndex = 10;
            this.dtpHoraEntrada.ValueChanged += new System.EventHandler(this.dtp_HoraEntrada_ValueChanged);
            // 
            // lbl_horaSaida
            // 
            this.lbl_horaSaida.AutoSize = true;
            this.lbl_horaSaida.BackColor = System.Drawing.Color.Transparent;
            this.lbl_horaSaida.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horaSaida.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_horaSaida.Location = new System.Drawing.Point(12, 134);
            this.lbl_horaSaida.Name = "lbl_horaSaida";
            this.lbl_horaSaida.Size = new System.Drawing.Size(120, 17);
            this.lbl_horaSaida.TabIndex = 12;
            this.lbl_horaSaida.Text = "Hora de Saída:";
            // 
            // dtpHoraSaida
            // 
            this.dtpHoraSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSaida.Location = new System.Drawing.Point(168, 129);
            this.dtpHoraSaida.Name = "dtpHoraSaida";
            this.dtpHoraSaida.ShowUpDown = true;
            this.dtpHoraSaida.Size = new System.Drawing.Size(85, 22);
            this.dtpHoraSaida.TabIndex = 14;
            // 
            // tb_ListaEntrada
            // 
            this.tb_ListaEntrada.Enabled = false;
            this.tb_ListaEntrada.Location = new System.Drawing.Point(362, 52);
            this.tb_ListaEntrada.Multiline = true;
            this.tb_ListaEntrada.Name = "tb_ListaEntrada";
            this.tb_ListaEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_ListaEntrada.Size = new System.Drawing.Size(228, 236);
            this.tb_ListaEntrada.TabIndex = 15;
            // 
            // lbl_ListaEntrada
            // 
            this.lbl_ListaEntrada.AutoSize = true;
            this.lbl_ListaEntrada.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ListaEntrada.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListaEntrada.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_ListaEntrada.Location = new System.Drawing.Point(413, 12);
            this.lbl_ListaEntrada.Name = "lbl_ListaEntrada";
            this.lbl_ListaEntrada.Size = new System.Drawing.Size(140, 17);
            this.lbl_ListaEntrada.TabIndex = 16;
            this.lbl_ListaEntrada.Text = "Lista de Entrada:";
            // 
            // lbl_ListaSaida
            // 
            this.lbl_ListaSaida.AutoSize = true;
            this.lbl_ListaSaida.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ListaSaida.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListaSaida.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_ListaSaida.Location = new System.Drawing.Point(673, 12);
            this.lbl_ListaSaida.Name = "lbl_ListaSaida";
            this.lbl_ListaSaida.Size = new System.Drawing.Size(120, 17);
            this.lbl_ListaSaida.TabIndex = 17;
            this.lbl_ListaSaida.Text = "Lista de Saída:";
            // 
            // tb_ListaSaida
            // 
            this.tb_ListaSaida.BackColor = System.Drawing.SystemColors.Window;
            this.tb_ListaSaida.Enabled = false;
            this.tb_ListaSaida.Location = new System.Drawing.Point(620, 52);
            this.tb_ListaSaida.Multiline = true;
            this.tb_ListaSaida.Name = "tb_ListaSaida";
            this.tb_ListaSaida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_ListaSaida.Size = new System.Drawing.Size(228, 236);
            this.tb_ListaSaida.TabIndex = 18;
            // 
            // dtpDataSaida
            // 
            this.dtpDataSaida.CalendarFont = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataSaida.Location = new System.Drawing.Point(168, 103);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(123, 22);
            this.dtpDataSaida.TabIndex = 13;
            // 
            // lbl_dataSaida
            // 
            this.lbl_dataSaida.AutoSize = true;
            this.lbl_dataSaida.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dataSaida.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataSaida.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_dataSaida.Location = new System.Drawing.Point(14, 108);
            this.lbl_dataSaida.Name = "lbl_dataSaida";
            this.lbl_dataSaida.Size = new System.Drawing.Size(119, 17);
            this.lbl_dataSaida.TabIndex = 11;
            this.lbl_dataSaida.Text = "Data de Saída:";
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.BackColor = System.Drawing.Color.Black;
            this.bt_Limpar.ForeColor = System.Drawing.Color.DarkCyan;
            this.bt_Limpar.Location = new System.Drawing.Point(374, 327);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(94, 46);
            this.bt_Limpar.TabIndex = 19;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = false;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 403);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.tb_ListaSaida);
            this.Controls.Add(this.lbl_ListaSaida);
            this.Controls.Add(this.lbl_ListaEntrada);
            this.Controls.Add(this.tb_ListaEntrada);
            this.Controls.Add(this.dtpHoraSaida);
            this.Controls.Add(this.dtpDataSaida);
            this.Controls.Add(this.lbl_horaSaida);
            this.Controls.Add(this.lbl_dataSaida);
            this.Controls.Add(this.dtpHoraEntrada);
            this.Controls.Add(this.dtpDataEntrada);
            this.Controls.Add(this.lbl_horaEntrada);
            this.Controls.Add(this.lbl_dataEntrada);
            this.Controls.Add(this.bt_Saida);
            this.Controls.Add(this.bt_Cadastrar);
            this.Controls.Add(this.tb_Placa);
            this.Controls.Add(this.lbl_placa);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CGaragem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.TextBox tb_Placa;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Button bt_Saida;
        private System.Windows.Forms.Label lbl_dataEntrada;
        private System.Windows.Forms.Label lbl_horaEntrada;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.Label lbl_horaSaida;
        private System.Windows.Forms.DateTimePicker dtpHoraSaida;
        private System.Windows.Forms.TextBox tb_ListaEntrada;
        private System.Windows.Forms.Label lbl_ListaEntrada;
        private System.Windows.Forms.Label lbl_ListaSaida;
        private System.Windows.Forms.TextBox tb_ListaSaida;
        private System.Windows.Forms.DateTimePicker dtpDataSaida;
        private System.Windows.Forms.Label lbl_dataSaida;
        private System.Windows.Forms.Button bt_Limpar;
    }
}


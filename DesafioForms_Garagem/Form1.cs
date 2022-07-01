using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioForms_Garagem
{
    public partial class Form1 : Form
    {
        private void popularTextBoxEntrada()
        {
            foreach (Veiculo i in listaVeiculosGaragem)
            {
                tb_ListaEntrada.AppendText(i.Placa + " - " + i.DataHoraEntrada + Environment.NewLine);

            }
        }
        private void popularTexBoxSaida()
        {
            foreach (Veiculo i in listaVeiculosForaGaragem)
            {
                tb_ListaSaida.AppendText(i.Placa + " - " + i.DataHoraSaida + Environment.NewLine);

            }
        }
        public Form1()
        {
            InitializeComponent();
            Persistencia.lerArquivoEntrada(listaVeiculosGaragem);
            this.popularTextBoxEntrada();
            Persistencia.configuracoesGaragem(ref tamanhoGaragem, ref valorHora);
        }

        private DateTimePicker timePicker;

        private void InitializeTimePicker()
        {
            timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.Location = new Point(10, 10);
            timePicker.Width = 100;
        }
        
        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
           
            if (Veiculo.temLugar(listaVeiculosGaragem, tamanhoGaragem))
            {
                Veiculo veiculo = new Veiculo(tb_Placa.Text, Convert.ToDateTime(dtpHoraEntrada.Text));

                if (Veiculo.localizado(veiculo.Placa, listaVeiculosGaragem) == -27)
                {
                    listaVeiculosGaragem.Add(veiculo);
                    //adicionar no arquivo
                    Persistencia.gravarNoArquivoEntrada(listaVeiculosGaragem);
                    MessageBox.Show(veiculo.Placa + " - " + veiculo.DataHoraEntrada);

                    //adicionar no textBox
                    tb_ListaEntrada.AppendText(veiculo.Placa + " - " + veiculo.DataHoraEntrada + Environment.NewLine);
                }
                else
                {
                    MessageBox.Show($"Alerta!\nVeículo já no pátio da garagem");
                }
            }
            else
            {
                MessageBox.Show("Garagem lotada!!!");
            }   
        }

        private void dtp_HoraEntrada_ValueChanged(object sender, EventArgs e)
        {
            InitializeTimePicker();
        }

        List<Veiculo> listaVeiculosGaragem = new List<Veiculo>();
        List<Veiculo> listaVeiculosForaGaragem = new List<Veiculo>();
        int tamanhoGaragem;
        double valorHora;

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            tb_ListaEntrada.Clear();
            tb_Placa.Clear();
            dtpDataEntrada.ResetText();
            dtpDataSaida.ResetText();
            dtpHoraEntrada.ResetText();
            dtpHoraSaida.ResetText();
        }

        private void bt_Saida_Click(object sender, EventArgs e)
        {
            Veiculo carro = new Veiculo(tb_Placa.Text, Convert.ToDateTime(dtpHoraEntrada.Text));

              this.popularTexBoxSaida();
            
                listaVeiculosForaGaragem.Add(carro);
                //adicionar no arquivo
                Persistencia.gravarNoArquivoSaida(listaVeiculosForaGaragem);
            MessageBox.Show(carro.Placa + " - " + carro.DataHoraEntrada +" - "+ carro.ValorCobrado) ;

                //adicionar no textBox
              tb_ListaSaida.AppendText(carro.Placa + " - " + carro.DataHoraEntrada + Environment.NewLine+" - "+ carro.ValorCobrado);

            

        }
    }
}

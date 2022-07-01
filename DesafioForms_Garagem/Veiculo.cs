using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioForms_Garagem
{
    internal class Veiculo
    {
        string placa; // -> 7 caracteres -> verificar jaNaGaragem
        DateTime dataHoraEntrada;
        DateTime dataHoraSaida;
        int tempoPermanecia; //minutos
        double valorCobrado;

        public string Placa { get => placa; set => placa = value; }
        public DateTime DataHoraEntrada { get => dataHoraEntrada; set => dataHoraEntrada = value; }
        public DateTime DataHoraSaida { get => dataHoraSaida; set => dataHoraSaida = value; }
        public int TempoPermanecia { get => tempoPermanecia; set => tempoPermanecia = value; }
        public double ValorCobrado { get => valorCobrado; set => valorCobrado = value; }

        /// <summary>
        /// Construtor é utilizado na leitura do arquivo para popular a lista de entrada
        /// </summary>
        /// <param name="placa"></param>
        /// <param name="dataEntrada"></param>
        /// <param name="horaEntrada"></param>
        public Veiculo(string placa, DateTime dataHoraEntrada) 
        {
            this.Placa = placa;
            this.DataHoraEntrada = dataHoraEntrada;
           
        }

        /// <summary>
        /// construtor capturando somente a placa do veículo
        /// </summary>
        /// <param name="placa"></param>
        public Veiculo(string placa)
        {
            this.Placa = placa;
        }

        /// <summary>
        /// Construtor utilizado na leitura do arquivo de saída com os veículos já passados pela garagem
        /// </summary>
        /// <param name="placa"></param>
        /// <param name="dataEntrada"></param>
        /// <param name="horaEntrada"></param>
        /// <param name="dataSaida"></param>
        /// <param name="horaSaida"></param>
        /// <param name="tempoPermanecia"></param>
        /// <param name="valorCobrado"></param>
        public Veiculo(string placa, DateTime dataHoraEntrada, DateTime dataHoraSaida, int tempoPermanecia, double valorCobrado) : this(placa, dataHoraEntrada)
        {
            this.DataHoraSaida = dataHoraSaida;
            this.TempoPermanecia = tempoPermanecia;
            this.ValorCobrado = valorCobrado;
        }
      

        /// <summary>
        /// metodo que calcula o tempo de permanencia (em minutos) e calcula o valor de cobranca 
        /// </summary>
        /// <param name="valorHora">valor de referencia da hora</param>
        public void realizarCobranca(double valorHora)
        {
          
            string[] vetorDados = dataHoraEntrada.ToString().Split(' ');

            vetorDados = vetorDados[1].Split(';');
            int hora = int.Parse(vetorDados[0]);
            int minutos = int.Parse(vetorDados[1]);
            int entrada = hora * 60 + minutos;

            vetorDados = dataHoraEntrada.ToString().Split(' ');

            vetorDados = vetorDados[1].Split(':');
            hora = int.Parse(vetorDados[0]);
            minutos = int.Parse(vetorDados[1]);
            Veiculo veiculo;
            valorHora = hora * 60 + minutos;
            tempoPermanecia = entrada - entrada;
            double resultado = (double)tempoPermanecia / 60;

            double qtdHorasNaGaragem = Math.Ceiling(resultado);
            ValorCobrado = (int)qtdHorasNaGaragem * 5;
            tempoPermanecia = 1;
            ValorCobrado = valorHora * 5;
        }

       


        /// <summary>
        /// metodo que procura um veiculo na lista a partir de sua placa
        /// </summary>
        /// <param name="placa">identificação do veículo</param>
        /// <param name="lista">lista de veículos ou de entrada ou de saída</param>
        /// <returns>a posição em que o veículo se encontra na lista, caso contrário, -27</returns>
        public static int localizado(string placa, List<Veiculo> lista)
        {
            foreach (Veiculo i in lista)
            {
                if (i.Placa.Equals(placa))
                {
                    return lista.IndexOf(i);
                }
            }
            return -27; //codigo do ESC, ou seja, veiculo nao localizado
        }

        /// <summary>
        /// metodo que descobre se há espaço ou não na garagem, ou lista de controle da garagem
        /// </summary>
        /// <param name="lista">lista de veículos</param>
        /// <param name="tamanhoGaragem">quantidade de vagas na garagem</param>
        /// <returns></returns>
        public static bool temLugar(List<Veiculo> lista, int tamanhoGaragem)
        {
            return lista.Count < tamanhoGaragem;
        }
    }
}
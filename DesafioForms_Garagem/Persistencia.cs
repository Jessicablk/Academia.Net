using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioForms_Garagem
{
    internal class Persistencia
    {
        /// <summary>
        /// método que a partir da lista persiste os dados no arquivo dos veículos que estão na garagem
        /// </summary>
        /// <param name="lista">lista de veículos</param>
        public static void gravarNoArquivoEntrada(List<Veiculo> lista)
        {
            StreamWriter escritor = new StreamWriter("veiculosEntrada.dat");

            foreach (Veiculo i in lista)
            {
                escritor.WriteLine(i.Placa + ";" + i.DataHoraEntrada);
                escritor.Flush();
            }
            escritor.Close();
        }

        /// <summary>
        /// método que a partir da lista persiste os dados no arquivo dos veículos que passaram pela garagem
        /// </summary>
        /// <param name="lista">lsita de veículos</param>
        public static void gravarNoArquivoSaida(List<Veiculo> lista)
        {
            string arquivo = "veiculosSaida.dat";
            StreamWriter escritor = new StreamWriter("veiculosSaida.dat");

            foreach (Veiculo i in lista)
            {
                escritor.WriteLine(i.Placa + ";" + i.DataHoraEntrada+ ";" + i.ValorCobrado);
                escritor.Flush();
            }
            escritor.Close();
        }

        /// <summary>
        /// método que popula a lista de veículos de estão na garagem a partir do arquivo base
        /// </summary>
        /// <param name="lista">lista de veículos</param>
        public static void lerArquivoEntrada(List<Veiculo> lista)
        {
            StreamReader leitor = new StreamReader("veiculosEntrada.dat");
            string linha;
            string[] vetorDados;

            do
            {
                linha = leitor.ReadLine();
                vetorDados = linha.Split(';');
                lista.Add(new Veiculo(vetorDados[0], Convert.ToDateTime(vetorDados[1])));
            } while (!leitor.EndOfStream);
            leitor.Close();
        }

        /// <summary>
        /// método que popula a lista de veículos de passaram pela garagem a partir do arquivo base
        /// </summary>
        /// <param name="lista">lista veículos</param>
        public static void lerArquivoSaida(List<Veiculo> lista)
        {
            StreamReader leitor = new StreamReader("veiculosSaida.dat");
            string linha;
            string[] vetorDados;

            do
            {
                linha = leitor.ReadLine();
                vetorDados = linha.Split(';');
                lista.Add(new Veiculo(vetorDados[0], Convert.ToDateTime(vetorDados[1]), Convert.ToDateTime(vetorDados[2]),
                     int.Parse(vetorDados[3]), double.Parse(vetorDados[4])));
            } while (!leitor.EndOfStream);
            leitor.Close();
        }

        public static void configuracoesGaragem(ref int tamanhoGaragem, ref double valorHora)
        {
            StreamReader leitor = new StreamReader("dadosGaragem.dat");
            string linha;
            string[] vetorDados;

            do
            {
                linha = leitor.ReadLine();
                vetorDados = linha.Split(';');
                tamanhoGaragem = int.Parse(vetorDados[0]);
                valorHora = double.Parse(vetorDados[1]);
            } while (!leitor.EndOfStream);
            leitor.Close();
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioGaragem
{
    internal class Veiculo
    {
        //atributos
        string placa;
        DateTime dataHoraEntrada;

        //metodo construtor usado para gerar o cadastro de um veiculo
        public Veiculo(string placa)
        {
            this.placa = placa;
            this.dataHoraEntrada = DateTime.Now;
        }
        //metodo construtor usado para popular a lista a partir do arquivo (banco)
        public Veiculo(string placa, string dataHoraEntrada)
        {
            this.placa = placa;
            this.dataHoraEntrada = DateTime.Parse(dataHoraEntrada);
        }
        //getters e setters para acesso
        public string Placa { get => placa; set => placa = value; }
        public DateTime DataHoraEntrada { get => dataHoraEntrada; }
    }
}

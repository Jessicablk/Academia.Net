using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseCarro
{
    public class Carro
    {
        //atributos
        public string modelo;
        public string marca;
        public string cor;
        public string placa;

        public bool ligado;
        
        //construtor
        public Carro(string mod, string mar, string cr, string pla)
        {
            modelo = mod;
            marca = mar;
            cor = cr;
            placa = pla;
        }
       //metodos = ações
        public void ligar()
        {
            Console.WriteLine("Ligando o carro.");
            ligado = true;
        }
        public void desligar()
        {
            Console.WriteLine("Desligando o carro.");
            ligado = false;
        }
    }

}

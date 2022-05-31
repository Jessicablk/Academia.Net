using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2
{
     class Animal
    {
        //atributos
        public string nome;
        public string tipo;
        public int qntddCachorros;
        public int qntddGatos;
        public int qntddPeixes;

        public Animal(string nome, string tipo, int qntddCachorros, int qntddGatos, int qntddPeixes)
        {
            this.Nome = nome;
            this.Tipo = tipo;
            this.QntddCachorros = qntddCachorros;
            this.QntddGatos = qntddGatos;
            this.QntddPeixes = qntddPeixes;
        }
        public string Nome { get => nome; set => nome = value ; }
        public string Tipo { get => tipo; set => tipo = value ; }
        public int QntddCachorros { get => qntddCachorros; set => qntddCachorros = value ; }
        public int QntddGatos { get => qntddGatos; set => qntddGatos = value ; }
        public int QntddPeixes { get => qntddPeixes; set => qntddPeixes = value ; }

        public void exibirInfo()
        {
            Console.Write($"Nome do animal: {Nome}.\n" +
                          $"Tipo do animal: {Tipo}.");
        }
        public static void mostrarQntddAnimal(List<Animal> lista)
        {
            Animal qntddCachorro = lista[0];

        }
    }
}

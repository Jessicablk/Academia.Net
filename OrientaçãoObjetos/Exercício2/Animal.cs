using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2
{
     internal class Animal
    {
        //atributos
        public string nome;
        public string tipo;
        
        //metodo construtor e sobrecarga
        public Animal()
        {

        }
        public Animal(string nome, string tipo)
        {
            this.Nome = nome;
            this.Tipo = tipo;
        }

        //metodos getters e setters
        public string Nome { get => nome; set => nome = value ; }
        public string Tipo { get => tipo; set => tipo = value ; }

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

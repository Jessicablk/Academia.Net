using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício1
{
     class Personagem
    {
        /// <summary>
        /// vaiavel que armazena o nome e o poder de um personagem
        /// </summary>
        string nome;
        int poder;

        /// <summary>
        /// construtor vazio
        /// </summary>
        public Personagem()
        {
        }

        /// <summary>
        /// construtor para um personagem com todos os atributos/variaveis
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="poder"></param>
        public Personagem(string nome, int poder)
        {
            this.Nome = nome;
            this.Poder = poder;
        }

        /// <summary>
        /// proprieddade de acesso ao nome e ao poder
        /// </summary>
        public string Nome { get => nome; set => nome = value; }
        public int Poder { get => poder; set => poder = value; }

        /// <summary>
        /// metodo de instancia/objeto para exibir dados completos de um personagem
        /// </summary>
        public void exibirDados()
        {
            Console.Write("Nome do personagem: " + Nome + ". Poder: " + Poder);
        }
        public static void mostrarMaisPoderoso(List<Personagem> lista)
        {
            Personagem maisPoderoso = lista[0];
            foreach (Personagem i in lista)
            {
                if (i.Poder > maisPoderoso.Poder)
                {
                    maisPoderoso = i;
                }
            }
            Console.WriteLine("O mais poderoso é: ");
            maisPoderoso.exibirDados();
        }
        public static string pegarMaisPoderoso(List<Personagem> lista)
        {
            Personagem maisPoderoso = lista[0];
            foreach(Personagem i in lista)
            {
                if (i.Poder > maisPoderoso.Poder)
                {
                    maisPoderoso = i;
                }
            }
            return maisPoderoso.Nome + " - " + maisPoderoso.Poder;
        }
    }
}

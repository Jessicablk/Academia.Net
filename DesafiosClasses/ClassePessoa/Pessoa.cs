using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassePessoa
{
    public class Pessoa
    {
        //atributos
        public string nome;
        public string sexo;
        public int idade;
        public string email;
        public double telefone;
        public double documento;

        public bool cadastro;

        //construtor
        public Pessoa(string n, string s, int idd, string e, double tel, double doc)
        {
            nome = n;
            sexo = s;
            idade = idd;
            email = e;
            telefone = tel;
            documento = doc;
        }
        //metodos=ações
        public void cadastrar()
        {
            Console.WriteLine("Cadastrando dados.");
            cadastro = true;
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaDasDisciplinas
{
    internal class Aluno
    {
        /// <summary>
        /// armazena os dados
        /// </summary>
        string matricula;
        string nome;
        string email;

        /// <summary>
        /// metodo construtor que instancia um objeto com todos os seus atributos
        /// </summary>
        /// <param name="matricula">recebe a matricula de um aluno</param>
        /// <param name="nome">recebe o nome completo de um aluno</param>
        /// <param name="email">recebe o email de um aluno</param>
        public Aluno(string matricula, string nome, string email)
        {
            this.Matricula = matricula;
            this.Nome = nome;
            this.Email = email;
        }
        /// <summary>
        /// propriedade/atributo que acessa as variaveis matricula, nome e email
        /// </summary>
        public string Matricula { get => matricula; set => matricula = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }

        /// <summary>
        /// metodo que retorna o primeiro nome e o último sobrenome
        /// </summary>
        /// <returns></returns>
        public string pegarNomeSobrenome()
        {
            string[] vetorNomes = this.Nome.Split(' ');
            if(vetorNomes.Length == 1)
            {
                return vetorNomes[0];
            }
            return vetorNomes[0] + " " + vetorNomes [ vetorNomes.Length - 1 ];
        }


    }
}

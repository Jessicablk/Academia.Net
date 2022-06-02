//Programa em VS que recebe emails de um usuário e que são gravados em arquivo.

using Drop6_ListaArquivoEscrito;

string opcao = "";
string nomeArquivo = "emails.dat"; // texto puro -> plain text

List<Pessoa> listaPessoas = new List<Pessoa>();

//verificar se o arquivo de dados existe e popular a listaPessoas
//abrir e ler os dados do arquivo, populando na lista
try //tratamento de exceções 
{
    StreamReader leitor = new StreamReader(nomeArquivo);//abre o arquivo para leitura
    string linha;
    string[] dados;
    do
    {
        linha = leitor.ReadLine();
        dados = linha.Split(";");
        Pessoa p = new Pessoa(dados[0], dados[1]);

        listaPessoas.Add(p);
    }while (!leitor.EndOfStream);

    leitor.Close();//fecha o objeto que representa o arquivo
}
catch (Exception e)
{
    //não faz nada, porque o arquivo será criado na linha 34
}


StreamWriter escritor = new StreamWriter(nomeArquivo, true);// abre o arquivo para escrita e com append
do
{
    Console.Clear();
    Console.WriteLine("  MENU  ");
    Console.WriteLine(" 1 - Cadastrar uma pessoa");
    Console.WriteLine(" 2 - Exibir pessoas");
    Console.WriteLine(" 3 - Sair");

    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            //receber um e-mail e gravar no arquivo
            try
            {
                string nome;
                string email;

                Console.Write("Digite o nome: ");
                nome = Console.ReadLine().ToUpper();

                Console.Write("Digite o e-mail: ");
                email = Console.ReadLine().ToUpper();

                //criar um objeto Pessoa com os valores nome e e-mail
                Pessoa p = new Pessoa(nome, email);

                //verificar se essa dupla já está na lista, logo no arquivo
                bool jaCadastrado = false;
                foreach (Pessoa i in listaPessoas)
                {
                    if (i.email.Equals(email))
                    {
                        Console.WriteLine("Este e-mail já está no sistema!");
                        jaCadastrado = true;
                        break;
                    }
                }
                if (!jaCadastrado)
                {
                    //adicionar o objeto na lista
                    listaPessoas.Add(p);
                    //adicionar o objeto no arqquivo
                    escritor.WriteLine(p.nome + ";" + p.email);//literalmente escreve no procurador e em memoria
                    escritor.Flush();//garante depois de cada frase digitada que vá para o arquivo
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao gravar o arquivo: " + e.Message);
            }
            break;
        case "2":
            Console.WriteLine("Exibindo a lista de pessoas");

            foreach (Pessoa i in listaPessoas)
            {
                Console.WriteLine(i.nome + " - " + i.email);
            }
            break;
        case "3":
            Console.WriteLine("Obrigado por usar o sistema!");
            break;
    }
    Console.Write("Pressione algo para continuar!");
    Console.ReadKey();
} while (opcao != "3");

escritor.Close();//fecha o objeto que representa o arquivo
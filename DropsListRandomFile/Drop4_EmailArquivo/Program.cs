// 4) Fazer um programa em VS, como o programa de número 2, entretando os emails devem ser coletados de um arquivo
// e populados em uma lista. Uma vez populados os emails na lista, o programa deve separar o nome de usuário (antes do @)
// do domínio do email (depois do @). Ao final, o programa deve exibir os domínios utilizados no cadastro 
// (não pode exibir os repetidos).

// Observação: os domínio são, por exemplo, gmail.com; yahoo.com.br; ufn.edu.br; hotmail.com; entre outros.

// Sugere-se usar um menu como:

// MENU 
// 1 - Abrir arquivo com emails e popular lista
// 2 - Mostrar lista de emails
// 3 - Mostrar dominíos de emails
// 4 - Sair
// Opção:____

List<string> listaEmails = new List<string>();
List<string> listaDominios = new List<string>();
string opcao;

do
{
    Console.Clear();
    Console.WriteLine("  MENU");
    Console.WriteLine(" 1 - Abrir arquivo com emails e popular lista");
    Console.WriteLine(" 2 - Mostrar lista de emails");
    Console.WriteLine(" 3 - Mostrar dominíos de emails");
    Console.WriteLine(" 4 - Sair");
    Console.WriteLine(" Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            // cadastrar e-mail
            Console.WriteLine("Abrindo arquivo de e-mails e populando a lista");
            string email;

            // abrir e ler os dados do arquivo, populando na lista
            try // tratamento de exceções
            {
                String nomeArquivo;
                Console.Write("Digite o nome do arquivo com os e-mails: ");
                nomeArquivo = Console.ReadLine();
                StreamReader leitor = new StreamReader(nomeArquivo); // abre o arquivo para leitura
                // StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8); //abre o arquivo para leitura

                do
                {
                    email = leitor.ReadToEnd();

                    if (!listaEmails.Contains(email)) ;
                    {
                        listaEmails.Add(email);

                        string[] emailSplit;
                        string dominio;
                        emailSplit = email.Split("@");
                        dominio = emailSplit[1];
                        if (!listaDominios.Contains(dominio))
                        {
                            listaDominios.Add(dominio);
                        }
                        listaDominios.Sort();
                    }
                } while (!leitor.EndOfStream);
                leitor.Close(); // fecha o objeto que representa o arquivo
            }
            catch (IOException e)
            {
                Console.WriteLine($"Erro ao ler o arquivo: {e.Message}");
            }
            break;
        case "2":
            // exibir lista dos e-mails
            Console.WriteLine("Exibindo a lista de e-mails");
            if (listaEmails.Count == 0)
            {
                Console.WriteLine("Lista vazia!");
            }
            else
            {
                for (int i = 0; i < listaEmails.Count; i++)
                {
                    Console.WriteLine(listaEmails[i]);
                }
                // foreach (int i in listaEmails)
                // {
                //     Console.WriteLine(i);
                // }
            }
            break;
        case "3":
            Console.WriteLine("Exibindo os domínios dos e-mails");
            if (listaEmails.Count == 0)
            {
                Console.WriteLine("Lista vazia!");
            }
            else
            {
                // listaDominios.Sort(); - poderia ser aqui
                foreach (string i in listaDominios)
                {
                    Console.WriteLine(i);
                }
            }
            break;
        case "4":
            Console.WriteLine("Obrigado por usar o sistema!");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    Console.Write("Pressione algo para continuar!");
    Console.ReadKey();
} while (opcao != "4");

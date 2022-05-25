// 4) Fazer um programa em VS, como o programa de número 2, entretando os emails devem ser
// coletados de um arquivo e populados em uma lista. Uma vez populados os emails na lista,
// o programa deve separar o nome de usuário (antes do @) do domínio do email (depois do @).
// Ao final, o programa deve exibir os domínios utilizados no cadastro (não pode exibir os
// repetidos). Observação: os domínio são, por exemplo, gmail.com; yahoo.com.br; ufn.edu.br;
// hotmail.com; entre outros.
// Sugere-se usar um menu como:
// MENU
// 1 - Abrir arquivo com emails e popular lista
// 2 - Mostrar lista de emails
// 3 - Mostrar dominíos de emails
// 4 - Sair
// Opção:__
// A partir do Drop4, refatora-lo para que o usário possa cadastrar email na lista, logo no
// arquivo. Para isso, sugiro criar a opção de menu 4 - Cadastrar email e passar a opção
// Sair para o número 5.


List<string> listaEmails = new List<string>();
List<string> listaDominios = new List<string>();
string opcao;
string email;
do
{
    Console.Clear();
    Console.WriteLine("  MENU");
    Console.WriteLine(" 1 - Abrir arquivo com e-mails e popular lista");
    Console.WriteLine(" 2 - Mostrar lista de e-mails");
    Console.WriteLine(" 3 - Mostrar dominíos de e-mails");
    Console.WriteLine(" 4 - Cadastrar e-mail:  ");
    Console.WriteLine(" 5 - Sair");
    Console.WriteLine(" Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            // cadastrar e-mail
            Console.WriteLine("Abrindo arquivo de e-mails e populando a lista");

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
            // cadastrar novo e-mail na lista e no arquivo = append novo e-mail
            Console.WriteLine("Cadastrar e-mail");
            if (listaEmails.Count.Equals(0)) // abrir arquivo e popular lista 
            {
                // abrir e ler os dados do arquivo, populando a lista
                try // tratamento de exceções
                {
                    StreamReader leitor = new StreamReader("emails.txt");//  //abre o arquivo para leitura
                                                                         //StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8); //abre o arquivo para leitura
                    do
                    {
                        email = leitor.ReadLine();
                        listaEmails.Add(email);
                    }while (!leitor.EndOfStream);
                    leitor.Close();// fecha o objeto que representa o arquivo
                }
                catch (IOException e)
                {
                    Console.WriteLine($"Erro ao ler o arquivo: {e.Message}");
                }
            }
            try //inserindo novo e-mail
            {
                StreamWriter escritor = new StreamWriter("emails.txt", true);
                Console.WriteLine("Digite um novo e-mail: ");
                email = Console.ReadLine().ToLower();
                if (!listaEmails.Contains(email))
                {
                    listaEmails.Add(email);
                    escritor.WriteLine(email);
                    escritor.Flush();
                    Console.WriteLine("E-mail gravado!");
                }
                else
                {
                    Console.WriteLine("E-mail já cadastrado!");
                }
                escritor.Close();
            }
            catch(Exception falha)
            {
                Console.WriteLine($"Erro ao salvar e-mail {falha.Message}");
            }
            break;
        case "5":
            Console.WriteLine("Obrigado por usar o sistema!");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    Console.Write("Pressione algo para continuar!");
    Console.ReadKey();
} while (opcao != "5");

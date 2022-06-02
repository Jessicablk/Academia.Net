// 2) Fazer um programa em VS que permita o usuário cadastrar emails de clientes (em uma lista). 
// Uma vez cadastrados os emails, o programa deve separar o nome de usuário (antes do @) do domínio do email 
// (depois do @). Ao final, o programa deve exibir os domínios utilizados no cadastro (não pode exibir os repetidos).
// Observação: os domínio são, por exemplo, gmail.com; yahoo.com.br; ufn.edu.br; hotmail.com; entre outros.

// Sugere-se usar um menu como:

// MENU 
// 1 - Cadastrar emails
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
    Console.WriteLine(" 1 - Cadastrar e-mails");
    Console.WriteLine(" 2 - Mostrar lista de e-mails");
    Console.WriteLine(" 3 - Mostrar dominíos de e-mails");
    Console.WriteLine(" 4 - Sair");
    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            //cadastrar e-mail
            Console.WriteLine("Cadastro de e-mail");
            string email;
            Console.WriteLine("Cadastre um e-mail: ");
            email = Console.ReadLine().ToUpper();
            if (listaEmails.Contains( email ))
            {
                Console.WriteLine("E-mail já cadastrado!");
            }
            else
            {
                listaEmails.Add( email );

                string[] emailSplit;
                string dominio;
                emailSplit = email.Split("@");
                dominio = emailSplit[1];
                if (!listaDominios.Contains(dominio))
                {
                    listaDominios.Add( dominio );
                }
                listaDominios.Sort();
                Console.WriteLine("E-mail cadastrado com sucesso!");
            }
            break;
        case "2":
            //exibir lista de e-mails
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
                //   Console.Writeline(i);
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
            Console.WriteLine("Obrigada por usar o sistema!");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    Console.Write("Pressione algo para continuar:");
    Console.ReadKey();
} while (opcao != "4");

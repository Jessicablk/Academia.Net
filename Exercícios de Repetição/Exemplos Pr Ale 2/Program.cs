// Ex 2: lista nome de pessoas e guardar na lista

List<string> listaPessoas = new List<string>();

string nome;

do
{
    Console.WriteLine("Digite um nome de pesso ou palavra sair para encerrar o programa: ");
    nome = Console.ReadLine().ToUpper();

    if (nome == "SAIR")
    {
        break;//encerra a repetição
    }
    listaPessoas.Add(nome);

} while (true);

//listaPessoas = [0, 1, 2, 3,...n]
for (int i = 0; i < listaPessoas.Count; i = i + 1)
{
    Console.WriteLine(listaPessoas[i]);
}

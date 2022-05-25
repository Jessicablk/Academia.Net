//Escreva uma classe Pessoa contendo todos os atributos de uma pessoa. Faça métodos para
//apresentar os dados.

using ClassePessoa;
Console.WriteLine("Digite seu nome completo: ");
string n = Console.ReadLine();
Console.WriteLine("Informe seu sexo (M/F): ");
string s = Console.ReadLine();
Console.WriteLine("Digite sua idade: ");
int idd = int.Parse(Console.ReadLine());
Console.WriteLine("Digite seu e-mail: ");
string e = Console.ReadLine();
Console.WriteLine("Informe um telefone para contato: ");
double tel = double.Parse(Console.ReadLine());
Console.WriteLine("Informe seu RG: ");
double doc = double.Parse(Console.ReadLine());

Pessoa p = new Pessoa(n, s, idd, e, tel, doc);

p.cadastrar();

Console.WriteLine($"----------------------------------------------------\n" +
                         $" Cadastro finalizado com sucesso!\n" +
                  $" Nome: {n}\n" +
                  $" Sexo: {s}\n" +
                  $" Idade: {idd}\n" +
                  $" E-mail: {e}" +
                  $" Telefone: {tel}\n" +
                  $" Documento: {doc}\n" +
                  $"----------------------------------------------------");


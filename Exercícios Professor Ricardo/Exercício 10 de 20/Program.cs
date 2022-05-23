// 10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura). O programa
// deve mostrar os dados do atleta mais novo e mais alto.

string atleta1, atleta2;
int idade1, idade2;
float altura1, altura2;

Console.WriteLine("Informe o nome do 1° atleta: ");
atleta1 = Console.ReadLine();
Console.WriteLine("Informe a idade do 1° atleta: ");
idade1 = int.Parse (Console.ReadLine());
Console.WriteLine("Informe a altura do 1° atleta: ");
altura1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o nome do 2° atleta: ");
atleta2 = Console.ReadLine();
Console.WriteLine("Informe a idade do 2° atleta: ");
idade2 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a altura do 2° atleta: ");
altura2 = float.Parse(Console.ReadLine());

if ((altura1 > altura2) && (idade1 < idade2))
{
    Console.WriteLine("O atleta " + atleta1 + " é o mais novo e mais alto.");
}
else if ((altura1 < altura2) && (idade1 > idade2))
{
    Console.WriteLine("O atleta " + atleta2 + " é o mais novo e mais alto.");
}
else
{
    Console.WriteLine("Não há atleta mais novo e mais alto ao mesmo tempo!");
}
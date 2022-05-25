// See https://aka.ms/new-console-template for more information

int num;
Console.WriteLine("Digite um número: ");
num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("Divisível por 2");
}
if (num % 4 == 0)
{
    Console.WriteLine("Divisível por 4");
}
if (num % 8 == 0)
{
    Console.WriteLine("Divisível por 8");
}
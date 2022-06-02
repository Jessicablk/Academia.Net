// 6.Faça um programa que leia um número n e imprima se ele é primo ou não. (um número primo
// tem apenas 2 divisores: 1 e ele mesmo! O número 1 não é primo!!!)

int num, divisor;
divisor = 0;

Console.Write("Digite um número: ");
num = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i < num; i++)
{
    if (num % i == 0)
    {
        divisor++;
    }
}
if(divisor == 2)
{
    Console.WriteLine("O número é primo.\n");
}
else
{
    Console.WriteLine("O número não é primo.\n");
}

Console.WriteLine("Programa encerrado!");



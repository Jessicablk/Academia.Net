//7 Faça um programa que leia um número e apresente a tabuada deste número;

int i, n, r;
Console.WriteLine("Digite a tabuada do número que deseja apresentar: ");
n = int.Parse(Console.ReadLine());

for (i = 0; i <11; i++)
{
    Console.WriteLine(i + "x" + n + " = " + i * n);
}

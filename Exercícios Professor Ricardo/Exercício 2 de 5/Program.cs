// 2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar.

int numero;


Console.WriteLine("Digite um número qualquer: ");
numero = int.Parse(Console.ReadLine());

if (numero % 2 == 1)
{
    Console.WriteLine("O número é impar!");
}
else
    {
    Console.WriteLine("O número é par!");
}


// 18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

double valor1, valor2, valor3, maior;

Console.WriteLine("Digite 3 valores quaisquer: ");
valor1 = double.Parse(Console.ReadLine());
valor2 = double.Parse(Console.ReadLine());
valor3 = double.Parse(Console.ReadLine());

maior = 0;

if (valor1 > valor2 && valor1 > valor3)
{
    maior = valor1;
}
if (valor2 > valor1 && valor2 > valor3)
{
    maior = valor2;
}
if (valor3 > valor1 && valor3 > valor2)
{
    maior = valor3;
}
if (valor1 == valor2 && valor2 == valor3)
{
    maior = valor1;
    Console.WriteLine("Os números são iguais!");
}
else
{
    Console.WriteLine("O número maior é: " + maior + ".");
}

// 3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e
// escrever na tela os que são superiores à média.

int num1;
int num2;
int num3;
int num4;
double media;

Console.WriteLine("Digite quatro números inteiros: ");
num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());
num3 = int.Parse(Console.ReadLine());
num4 = int.Parse(Console.ReadLine());

media = (num1 + num2 + num3 + num4)/ 4;
Console.WriteLine("A média é: " + media);
Console.WriteLine("Os valores superiores à média são: ");

if (num1> media)
{
    Console.WriteLine(num1);
}

if (num2 > media)
{
    Console.WriteLine(num2);
}
if (num3 > media)
{
    Console.WriteLine(num3);
}
if (num4 > media)
    {
    Console.WriteLine(num4);
}

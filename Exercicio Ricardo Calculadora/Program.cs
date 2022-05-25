// See https://aka.ms/new-console-template for more information

double num1, num2, resultado;
int op;
Console.WriteLine("Digite dois números: ");
num1 = double.Parse(Console.ReadLine());
num2 = double.Parse(Console.ReadLine());
Console.WriteLine("\nEscolha a operação:\n1.Soma\n2.Subtração\n3.Multiplicação\n4.Divisão\n5.Potencia\n\nEscolha: ");
op = int.Parse(Console.ReadLine());
if (op == 1)
{
    resultado = num1 + num2;
    Console.WriteLine("Soma = " + resultado);
}
else if (op == 2)
{
    resultado = num1 - num2;
    Console.WriteLine("Subtração = " + resultado);
}
else if (op == 3)
{
    resultado = num1 * num2;
    Console.WriteLine("Multiplicação = " + resultado);
}
else if (op == 4)
{
    resultado = num1 / num2;
    Console.WriteLine("Divisão = " + resultado);
}
else if (op == 5)
{
    resultado = num1 % num2;
    Console.WriteLine("Potencia = " + resultado);
}

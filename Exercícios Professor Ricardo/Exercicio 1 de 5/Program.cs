// 1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores
// da base e da altura lidos pelo teclado: Área do triangulo = (base * altura) / 2.
// Teste se a base ou a altura digitada não foi igual a zero.

float altura;
float baset;
float area;

Console.WriteLine("Digite o valor da base do triângulo: ");
baset = float.Parse(Console.ReadLine());
if (baset >= 0)
{
    Console.WriteLine("Digite o valor da altura do triângulo: ");
    altura = float.Parse(Console.ReadLine());

    area = (baset * altura) / 2;
    Console.WriteLine("A area do triângulo é: " + area);
}
else
{
    Console.WriteLine("O número deve ser maior que 0!");
}






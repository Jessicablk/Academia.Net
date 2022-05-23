// 17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então
// diga se esses lados podem ou não formar um triangulo. Para que os lados formem um triângulo,
// todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem
// um triangulo, diga se o mesmo é equilátero (todos os lados iguais), isoceles(somente 2 lados
// são iguais) ou escaleno(os 3 lados são diferentes).

float ladoA, ladoB, ladoC;

Console.WriteLine("Digite o lado A do triângulo: ");
ladoA = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o lado B do triângulo: ");
ladoB = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o lado C do triângulo: ");
ladoC = float.Parse(Console.ReadLine());

if (ladoA <= ladoB + ladoC)
{
    if (ladoB <= ladoC + ladoA)
    {
        if (ladoC <= ladoA + ladoB)
        {
            Console.WriteLine("Os valores informados formam um triângulo!");

            if (ladoA == ladoB && ladoC == ladoB)
            {
                Console.WriteLine("Este triângulo é equilátero.");
            }
            else if (ladoA == ladoB && ladoA != ladoC)
            {
                Console.WriteLine("Este triângulo é isóceles.");
                if (ladoB == ladoC && ladoB != ladoA)
                {
                    Console.WriteLine("Este triângulo é isóceles.");
                }
                if (ladoA == ladoC && ladoA != ladoB)
                {
                    Console.WriteLine("Este triângulo é isóceles.");
                }
            }
            else if (ladoA != ladoB && ladoB != ladoC)
            {
                Console.WriteLine("Este triângulo é escaleno.");
            }
        }
        else
        {
            Console.WriteLine("Os valores informados não formam um triângulo!");
        }
    }
    else
    {
        Console.WriteLine("Os valores informados não formam um triângulo!");
    }
}
else
{
    Console.WriteLine("Os valores informados não formam um triângulo!");
}
    
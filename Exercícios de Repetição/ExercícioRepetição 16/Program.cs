// 16. Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da multiplicação
// sucessiva de N por 3 enquanto o produto for menor que 250 (N*3; N * 3 * 3; N * 3 * 3 * 3; etc).

int numeroN;
double multiplicacao;

while (true)
{
    Console.WriteLine("Digite um valor menor ou igual a 50: ");
    numeroN = int.Parse(Console.ReadLine());

    if (numeroN <= 50)
    {
        break;
    }
    else
    {
        Console.WriteLine("Número inválido!");
    }
}

multiplicacao = numeroN;
while (true)
{
    multiplicacao *= 3;
    if (multiplicacao >= 250)
    {
        break;
    }
    else
    {
        Console.WriteLine("O valor da multiplicação do número informado por 3 é: {0:F2}\n", multiplicacao);
    }
}

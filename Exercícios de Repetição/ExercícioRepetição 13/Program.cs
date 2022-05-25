// 13. Elaborar um programa que apresente o somatório dos valores pares existentes entre 1 e
// 500.

int soma = 0;
for (int i = 1; i < 500; i++)
{
    if (i % 2 == 0)
    {
        soma += 1;
    }
}
Console.WriteLine($"A soma dos valores pares existentes entre 1 e 500 é: {soma}");

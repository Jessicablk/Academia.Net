// 17. Apresentar os quadrados dos números inteiros de 15 a 200.


// declaração da variáveis
int cont = 15;

// repetição para exibir o quadrado dos números inteiros positivo de 15 a 200.
for (int i = 15; i <= 200; i++)
{
    Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}.");
}
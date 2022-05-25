// 18. Elaborar um programa que apresente o valor de uma potência de uma base qualquer
// elevada a um expoente qualquer, ou seja, NM.

float valor1, valor2, potencia;
string pergunta = "";

do
{
    Console.Clear();
    Console.WriteLine("Vamos calcular a potência de um número...");
    Console.WriteLine();
    Console.WriteLine("Digite um valor para a base: ");
    valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite um valor para o expoente: ");
    valor2 = float.Parse(Console.ReadLine());

    potencia = MathF.Pow(valor1, valor2);
    Console.WriteLine();
    Console.WriteLine($"{valor1}^{valor2} = {potencia:F2}");

    Console.WriteLine();
    Console.WriteLine("Deseja calcular uma nova potência (S/N)? ");
    pergunta = Console.ReadLine().ToUpper();

    if (pergunta == "S")
    {
        continue;
    }
    else if (pergunta == "N")
    {
        break;
    }
    else
    {
        Console.WriteLine("Opção inválida!");
        Console.WriteLine("Pressione algo para tentar novamente.");
    }
    Console.ReadKey();
}while(true);

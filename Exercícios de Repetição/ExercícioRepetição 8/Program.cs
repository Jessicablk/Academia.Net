//8. Faça um programa em VS que solicite um numero inteiro. Se o numero não for inteiro,
//solicite-o até que seja. após, informe se ele é par ou impar. Finalmente, pergunte ao
//usuário se ele quer repetir o programa em VS.

int num;
char novoNum;

while (true)
{
    Console.WriteLine("Digite um número inteiro: ");
    if (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("O número informado não é inteiro!");
    }
    if (num > 0 && num % 2 == 0)
    {
        Console.WriteLine("O número informado é par.");
    }
    else if (num > 0 && num % 2 != 0)
    {
        Console.WriteLine("O número informado é impar.");
    }
    
    Console.WriteLine("Deseja informar outro numero (S/N)?");
    novoNum = char.Parse(Console.ReadLine());

    if (novoNum == 'S' || novoNum == 's')
    {

    }
    
    else { break; }
}




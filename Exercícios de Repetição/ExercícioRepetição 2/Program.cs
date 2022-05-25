//2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele
//deseja informar um outro número. Caso positivo, o programa em VS deve ser repetido.

int numero;
char outroNumero;
while (true)
{
    do
    {
        Console.WriteLine("Digite um número inteiro positivo: ");
        numero = int.Parse(Console.ReadLine());
        if (numero < 0)
        {
            Console.WriteLine("O número informado não é positivo!");
        }
    } while (numero < 0);
    Console.WriteLine($"Número digitado: {numero}.");
    Console.WriteLine($"Números inteiros pares entre 1 e {numero}: ");
    for (int i = 1; i <= numero; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i + " ");
        }
    }
    Console.WriteLine("Deseja informar outro número (s/n)? ");
    outroNumero = char.Parse(Console.ReadLine());
    if (outroNumero == 'n' || outroNumero == 'N')
    {
        break;
    }
}
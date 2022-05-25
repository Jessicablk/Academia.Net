// Um programa para gerenciar os saques de um caixa eletrônico deve possuir
// algum mecanismo para decidir o número de notas de cada valor que deve
// ser disponibilizado para o cliente que realizou o saque.
// Um possível critério seria o da “distribuição ótima” no sentido de que
// as notas de menor valor fossem distribuídas em número mínimo possível.
// Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria
// indicar uma nota de R$ 50,00,três notas de R$ 10,00, uma nota de
// R$ 5,00 e duas notas de R$ 1,00. Escreva um programa que receba o
// valor da quantia solicitada e retorne a distribuição das notas de
// acordo com o critério da “distribuição ótima”.

Console.WriteLine("Um programa para gerenciar os saques de um caixa eletrônico\n" +
    " deve possuir algum mecanismo para decidir o número de notas de cada\n" +
    " valor que deve ser disponibilizado para o cliente que realizou o\n" +
    " saque.Um possível critério seria o da “distribuição ótima” no\n" +
    "sentido de que as notas de menor valor fossem distribuídas em número\n" +
    " mínimo possível. Por exemplo, se a quantia solicitada fosse \n" +
    "R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, três notas\n" +
    " de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. Escreva\n" +
    " um programa que receba o valor da quantia solicitada e retorne a \n" +
    "distribuição das notas de acordo com o critério da “distribuição ótima”.");

int[] notas = { 200, 100, 50, 20, 10, 5, 2 };

int quantidadeNotas200 = 0;
int quantidadeNotas100 = 0;
int quantidadeNotas50 = 0;
int quantidadeNotas20 = 0;
int quantidadeNotas10 = 0;
int quantidadeNotas5 = 0;
int quantidadeNotas2 = 0;

System.Console.WriteLine($"Qual o saldo na conta: ");
double saldoNaConta = double.Parse(Console.ReadLine());

System.Console.WriteLine($"Qual o valor do saque: ");
double ValorSaque = double.Parse(Console.ReadLine());
double resto = ValorSaque;

foreach (var item in notas)
{
    if (item > resto)
    {
        continue;
    }
    else
    {
        if (item == 200)
        {
            quantidadeNotas200 = Convert.ToInt16(Math.Floor(resto / item));
            resto = resto % item;
        }

        else if (item == 100)
        {
            quantidadeNotas100 = Convert.ToInt16(Math.Floor(resto / item));
            resto = resto % item;
        }

        else if (item == 50)
        {
            quantidadeNotas50 = Convert.ToInt16(Math.Floor(resto / item));
            resto = resto % item;
        }

        else if (item == 20)
        {
            quantidadeNotas20 = Convert.ToInt16(Math.Floor(resto / item));
            resto = resto % item;
        }

        else if (item == 10)
        {
            quantidadeNotas10 = Convert.ToInt16(Math.Floor(resto / item));
            resto = resto % item;
        }

        else if (item == 5)
        {
            quantidadeNotas5 = Convert.ToInt16(Math.Floor(resto / item));
            resto = resto % item;
        }

        else if (item == 2)
        {
            quantidadeNotas2 = Convert.ToInt16(Math.Floor(resto / item));
            resto = resto % item;
        }
    }
}

System.Console.WriteLine($"A quantidade de notas de 200 será: {quantidadeNotas200}");
System.Console.WriteLine($"A quantidade de notas de 100 será: {quantidadeNotas100}");
System.Console.WriteLine($"A quantidade de notas de 50 será: {quantidadeNotas50}");
System.Console.WriteLine($"A quantidade de notas de 20 será: {quantidadeNotas20}");
System.Console.WriteLine($"A quantidade de notas de 10 será: {quantidadeNotas10}");
System.Console.WriteLine($"A quantidade de notas de 5 será: {quantidadeNotas5}");
System.Console.WriteLine($"A quantidade de notas de 2 será: {quantidadeNotas2}");
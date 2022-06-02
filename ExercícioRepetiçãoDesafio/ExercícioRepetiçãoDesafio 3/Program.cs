// 3.Dado um limite inferior e superior, calcule a soma de todos os números pares contidos
// nesse intervalo.

int inferior, superior, par;

par = 0;

Console.Write("Digite o valor inferior: ");
inferior = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Digite o valor superior: ");
superior = int.Parse(Console.ReadLine());
Console.WriteLine();
 if (inferior < superior)
{
    for (int i = inferior; i <= superior; i++)
    {
        if (i % 2 == 0)
        {
            par += i;
        }
    }
    Console.WriteLine("A soma dos números pares de {0} a {1} é {2}.\n", inferior, superior, par);
}
 else if (inferior > superior)
{
    for (int i = inferior; i >= superior; i--)
    {
        if (i % 2 == 0)
        {
            par += i;
        }
    }
    Console.WriteLine("A soma dos números pares de {0} a {1} é {2}.\n", inferior, superior, par);
}
else
{
    Console.WriteLine("Os valores são iguais!");

    if(inferior % 2 == 0 && superior % 2 == 0)
    {
        Console.WriteLine("Os valores {0} e {1} são pares.\n", inferior, superior);
    }
    else
    {
        Console.WriteLine("Os valores {0} e {1} são ímpares.\n", inferior, superior);
    }
}

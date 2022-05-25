//  Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e
//  para o parafuso B, isto é, o código, a quantidade de peças e o valor unitário de
//  cada parafuso e a porcentagem de IPI (única) a ser acrescentada. 

//Parafuso A
Console.WriteLine("Digite o código do parafuso A: ");
int codigoParafusoA = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de parafusos A: ");
int qntddParafusoA = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor unitário de parafusos do tipo A: ");
double valorParafusoA = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o percentual (%) de IPI de cada parafuso do tipo A: ");
double percentualIPIParafusoA = double.Parse(Console.ReadLine());

//Parafuso B
Console.WriteLine("Digite o código do parafuso B: ");
int codigoParafusoB = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de parafusos B: ");
int qntddParafusoB = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor unitário de parafusos do tipo B: ");
double valorParafusoB = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o percentual (%) de IPI de cada parafuso do tipo B: ");
double percentualIPIParafusoB = double.Parse(Console.ReadLine());

//Mostrando dados do parafuso A
Console.WriteLine($"Código do parafuso A: {codigoParafusoA}");
Console.WriteLine($"Quantidade do parafuso A: {qntddParafusoA}");
Console.WriteLine($"Valor unitário do parafuso A: {valorParafusoA}");
Console.WriteLine($"Percentual IPI do parafuso A: {percentualIPIParafusoA}");

double valorTotalParafusoASemIPI = valorParafusoA * qntddParafusoA;
Console.WriteLine($"Valor total do parafuso A sem IPI: {valorTotalParafusoASemIPI}");

double vlaorTotalDoParafusoAComIPI = valorParafusoA * qntddParafusoA + (valorParafusoA * (percentualIPIParafusoA / 100) * qntddParafusoA);
Console.WriteLine($"Valor total do parafuso A com IPI: {vlaorTotalDoParafusoAComIPI}");

//Mostrando dados do parafuso B
Console.WriteLine($"Código do parafuso B: {codigoParafusoB}");
Console.WriteLine($"Quantidade do parafuso B: {qntddParafusoB}");
Console.WriteLine($"Valor unitário do parafuso B: {valorParafusoB}");
Console.WriteLine($"Percentual IPI do parafuso B: {percentualIPIParafusoB}");

double valorTotalParafusoBSemIPI = valorParafusoB * qntddParafusoB;
Console.WriteLine($"Valor total do parafuso B sem IPI: {valorTotalParafusoBSemIPI}");

double vlaorTotalDoParafusoBComIPI = valorParafusoB * qntddParafusoB + (valorParafusoB * (percentualIPIParafusoB / 100) * qntddParafusoB);
Console.WriteLine($"Valor total do parafuso B com IPI: {vlaorTotalDoParafusoBComIPI}");

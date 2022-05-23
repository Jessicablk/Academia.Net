//Ler uma temperatura em graus Celsius e apresentá-la convertida em graus
//Fahrenheit. A fórmula da conversão é F=(9*C+160)/ 5.

Console.WriteLine("Ler uma temperatura em graus Celsius e apresentá-la\n" +
    " convertida em graus Fahrenheit.\n" +
    " A fórmula da conversão é F = (9 * C + 160) / 5.");


Console.WriteLine("Conversor de temperatura: ");

Console.WriteLine("Digite a temperatura em °C: ");
double graus = double.Parse(Console.ReadLine());
double conversao = (9 * graus + 160) / 5;
Console.WriteLine($"O resultado da conversão em Fahrenheit é: {conversao} Fahrenheit");


// 15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros
// quadrados da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada
// 3 metros quadrados e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00.
// Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.


float tamanhoMetroQ, qntdTinta, qntdLatas, precoTotal;

Console.WriteLine("Informe a área a ser pintada em m²: ");
tamanhoMetroQ = float.Parse(Console.ReadLine());
qntdTinta = tamanhoMetroQ / 3;
qntdLatas = (int)Math.Ceiling(qntdTinta / 18);
precoTotal = qntdLatas * 80;

Console.WriteLine("A quantidade de tinta para cobrir a área é de: " + qntdTinta + " litros.");
Console.WriteLine("A quantidade de latas de 18 litros para cobrir a área é de: " + qntdLatas + " latas.");
Console.WriteLine("O valor total da sua compra é de: R$ " + precoTotal + ".");


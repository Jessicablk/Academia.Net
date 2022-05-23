//Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um
//automóvel (medido em Km/l), sendo que são conhecidos a distância total percorrida e o
//volume de combustível consumido para percorrê-la (medido em l).

Console.WriteLine("Escreva um programa em C# e no Visual Studio para calcular o consumo\n" +
    " médio de um automóvel (medido em Km / l), sendo que são conhecidos a distância total\n" +
    " percorrida e o volume de combustível consumido para percorrê - la(medido em l).");

double consumoMedio;
double distanciaTotal;
double volumeDeCombustivel;

Console.WriteLine("Digite a kilometragem percorrida: ");
distanciaTotal = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de combustível usada: ");
volumeDeCombustivel = double.Parse(Console.ReadLine());

consumoMedio = distanciaTotal / volumeDeCombustivel;

Console.WriteLine("O consumo médio de seu automóvel é de: " +consumoMedio+ " km/l");


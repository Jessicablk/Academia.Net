﻿// 2.Imprima uma tabela de conversão de polegadas para centímetros, de 1 a 20. Considere que
// Polegada = Centímetro * 2,54.

// declarando as variaveis 
double centimetro, polegada;

// atribuição do valor de conversão
polegada = 2.54;

// imprime o cabeçalho da tabela
Console.WriteLine("---------------------------------------");
Console.WriteLine("||    POLEGADAS    |   CENTÍMETROS   ||");

for (int i = 1; i <= 20; i++)
{
    // efetua o calculo de conversão e imprime na tela 
    centimetro = (double)i * polegada;
    Console.WriteLine("||      {0:00.00}      |      {1:00.00}      ||", i, centimetro);
}
Console.WriteLine("---------------------------------------");

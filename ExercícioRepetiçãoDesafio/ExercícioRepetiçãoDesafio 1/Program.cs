﻿// 1. Faça um programa que leia um número inteiro n, inteiro e positivo e mostre a seguinte
// soma: S = 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5....1 / n

//declarando as variaveis
string numeroDigitado;
int numero;
double soma = 0;

//repetição infinita
while (true)
{
    // imprime na tela a mensagem, lê o valor digitado e salva na variável
    Console.Write("Digite um número inteiro e positivo: ");
    numeroDigitado = Console.ReadLine();

    // realizaa verificação se o número é inteiro e positivo
    if(int.TryParse(numeroDigitado, out numero) && numero > 0)
    {
        // repetição de 1 até o número informado
        for (int i = 1; i <= numero; i++)
        {
            soma += (double)1 / i;
        }
        // imprime na tela o resultado da soma inversa do número
        Console.WriteLine("A soma inversa de 0 até {0:F2} é: {1:F2}", numero, soma);

        //quebra de repetição infinita
        break;
    }
    else
    {
        Console.WriteLine("Número inválido! Digite apenas um número inteiro e positivo.");
    }
}




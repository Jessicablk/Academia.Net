﻿// 6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em
// maiúsculo), a altura (metros) e o peso (kg) de uma pessoa. O programa deve calcular o
// Indice de Massa Corpórea (IMC), exibi - lo ao usuário e informar sua situação conforme
// a tabela. O cálculo do imc = peso / (altura * altura).
//IMC
//menor que 18                -> baixo peso
//maior que 18 e menor que 25 -> peso normal
//maior que 25 e menor que 30 -> sobrepeso
//maior que 30 e menor que 35 -> obesidade
//maior que 35                -> obesidade grau sério

// declarar variáveis 
string nome;
float altura, peso, imc;

//receber e guardar as informações passadas pelo usuário
Console.WriteLine("Digite seu nome completo: ");
nome = Console.ReadLine();
nome = nome.ToUpper();

Console.WriteLine("Digite o seu peso: ");
peso = float.Parse(Console.ReadLine());
Console.WriteLine("Digite sua altura: ");
altura = float.Parse(Console.ReadLine());
imc = peso / (altura * altura);

//testagem das condições 
if (imc < 18)
{
    Console.WriteLine(nome + " você está abaixo do peso, IMC: " + imc);
}
else if (imc > 18 && imc < 25)
{
    Console.WriteLine(nome + " você está com o peso normal, IMC: " + imc);
}
else if (imc > 25 && imc <30)
{
    Console.WriteLine(nome + " você está acima do peso, IMC: " + imc);
}
else if (imc > 30 && imc < 35)
{
    Console.WriteLine(nome + " você está com obesidade, IMC: " + imc);
}
else
{
    Console.WriteLine(nome + " você está com obesidade grau sério, IMC: " + imc);
}

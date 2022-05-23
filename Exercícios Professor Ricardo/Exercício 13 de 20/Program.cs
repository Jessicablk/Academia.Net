//13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que
//calcule seu peso ideal, utilizando as seguintes fórmulas:
//Para homens: (72.7 * h) - 58
//Para mulheres: (62.1 * h) - 44.7 

//declarar as varáveis 
string nome, sexo;
double altura, pesoIdealH, pesoIdealM;

//receber dados
Console.WriteLine("Digite seu nome: ");
nome = Console.ReadLine();
Console.WriteLine("\nInforme o Sexo M-(Masculino)  F-(Feminino): ");
sexo = Console.ReadLine();
Console.WriteLine("\nDigite sua altura: ");
altura = double.Parse(Console.ReadLine());

//processamento de dados
if (sexo.ToLower() == "m")
{
    pesoIdealH = (72.7 * altura) - 58;
    Console.WriteLine($"\nO seu peso ideal {nome} é: {pesoIdealH:F1}.");
}
else if (sexo.ToLower() == "f")
{
    pesoIdealM = (62.1 * altura) - 44.7;
    Console.WriteLine($"\nO seu peso ideal {nome} é: {pesoIdealM:F2}.");
}

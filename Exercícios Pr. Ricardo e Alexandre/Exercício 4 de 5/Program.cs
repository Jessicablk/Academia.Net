// 4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores
// e o valor por hora recebido por cada um deles.
// Mostrar na tela qual dos professores tem o maior salário total.

//declarar as váriaveis
double horasaula1, valor1, sal1, horasaula2, valor2, sal2;

//guardar os dados informados pelo Professor 1
Console.WriteLine("Digite a quantidade de horas aula dadas pelo Professor 1: ");
horasaula1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor por hora recibido pelo Professor 1: ");
valor1 = double.Parse(Console.ReadLine());

//guardar os dados informados pelo Professor 2
Console.WriteLine("Digite a quantidade de horas aula dadas pelo Professor 2: ");
horasaula2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor por hora recebido pelo Professor 2: ");
valor2 = double.Parse(Console.ReadLine());

sal1 = horasaula1 * valor1;
sal2 = horasaula2 * valor2;

//testagem lógica para saber qual é o maior salário entre os dois 
if (sal1 > sal2)
{
    Console.WriteLine("O Professor 1 ganha mais do que o Professor 2!");
}
else 
        {
    Console.WriteLine("O Professor 2 ganha mais do que o Professor 1!");
}

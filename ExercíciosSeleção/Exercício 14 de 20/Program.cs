// 14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade
// de um link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download
// do arquivo usando este link (em minutos).

//declarar as variáveis
double tamanhoMB, velocidade, tempoEmMinutos;

//coletar os dados
Console.WriteLine("Informe o tamanho do arquivo (em MB - megabytes): ");
tamanhoMB = double.Parse(Console.ReadLine());
Console.WriteLine("Informe a velocidade da Internet (em Mbps - Megabits por segundo): ");
velocidade = double.Parse(Console.ReadLine());

tempoEmMinutos = tamanhoMB / velocidade;
Console.WriteLine($"O tempo aproximado de download é: {tempoEmMinutos}.");

// 11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra
// para minutos). O programa deve exibir se a hora digitada está ou não válida. Lembre que usaremos
// o padrão de hora com 24h, de 0 a 23.

int horas, minutos;

Console.WriteLine("Informe a hora: ");
horas = int.Parse(Console.ReadLine());
Console.WriteLine("Informe os minutos: ");
minutos = int.Parse(Console.ReadLine());

if (horas >= 0 && horas < 24 && minutos >= 0 && minutos < 60)
{
    Console.WriteLine("O horário informado é válido. São: " + horas + ":" + minutos);
}
else
{
    Console.WriteLine("O horário informado não é válido.");
}
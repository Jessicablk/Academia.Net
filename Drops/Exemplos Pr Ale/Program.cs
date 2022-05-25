// Ex 1: Repetição para validar entradas em variáveis

float notaBimestral;

do
{
    Console.Clear();
    Console.WriteLine("Digite uma nota válida (0 a 10): ");
    notaBimestral = float.Parse(Console.ReadLine());

    if (notaBimestral < 0 || notaBimestral > 10)
    {
        Console.WriteLine("Nota inválida...presta atenção, notas de 0 a 10! Tecle algo para continuar...");
        Console.ReadKey();//ler a tecla
    }

} while (notaBimestral < 0 || notaBimestral > 10);

Console.WriteLine("Parabéns..você digitou uma nota válida!");


//14. Mostrar as potências de 2 variando de 0 a 10.

int potencia = 2;
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"2 ^ {i} = {Math.Pow(potencia, i)}");
}
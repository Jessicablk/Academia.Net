// Ex 3

int valorGlicemia; //45 a 450
List<int> listaGlicemias = new List<int>();

int TOTAL = 10;
for (int i = 0; i < TOTAL; i++)
{
    do
    {
        Console.WriteLine("Digite um valor de glicemia valido [45 a 450]: ");
        valorGlicemia = int.Parse(Console.ReadLine());
        if (valorGlicemia >= 45 && valorGlicemia <= 450)
        {
            break;
        }
        else
        {
            Console.WriteLine("Valor inválido! Atente para 45 a 450!");
        }
    } while (true);

    listaGlicemias.Add(valorGlicemia);

}

for (int i = 0; i < listaGlicemias.Count; i = i + 1)
{
    Console.WriteLine(listaGlicemias[i]);
}

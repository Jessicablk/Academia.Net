// 15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo
// se ele está aprovado ou reprovado, após ter calculado sua média ponderando, considerando
// pesos 2, 1, 2, e 4, respectivamente. Considerar nota 7,0 como mínima para aprovação.

double[] nota = new double[4];
double mediaPonderada;

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Informe a {0}ª nota: ", i + 1);
    nota[i] = double.Parse(Console.ReadLine());
}

mediaPonderada = (double)((nota[0] * 2) + (nota[1] * 1) + (nota[2] * 2) + (nota[3] * 4)) / 9;
Console.WriteLine("A média ponderada é: {0:F2}", mediaPonderada);

if (mediaPonderada >= 7) 
    {
    Console.WriteLine("Parabéns! Aluno aprovado!");
}
else
{
    Console.WriteLine("Aluno reprovado!");
}
    
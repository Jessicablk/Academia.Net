// 19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente:
// (18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.


int n1, n2, n3;
double maior;

Console.WriteLine("Digite 3 números quaisquer: ");
n1 = int.Parse(Console.ReadLine());
n2 = int.Parse(Console.ReadLine());
n3 = int.Parse(Console.ReadLine());

maior = 0;

Console.WriteLine($"O número maior é: {maior}.");

if (n1 < n2 && n2 < n3)
{
    Console.WriteLine($"A ordem crescente dos números informados é: {n1}, {n2} e {n3}.");
}
else if (n1 < n3 && n3 < n2)
{
    Console.WriteLine($"A ordem crescente dos números informados é: {n1}, {n3} e {n2}.");
}
else if (n3 < n2 && n2 < n1)
{
    Console.WriteLine($"A ordem crescente dos números informados é: {n3}, {n2} e {n1}.");
}
else if (n2 < n1 && n1 < n3)
{
    Console.WriteLine($"A ordem crescente dos números informados é: {n2}, {n1} e {n3}.");
}
else if (n2 < n3 && n3 < n1)
{
    Console.WriteLine($"A ordem crescente dos números informados é: {n2}, {n3} e {n1}");
}
else if (n3 < n1 && n1 < n2)
{
    Console.WriteLine($"A ordem crescente dos números informados é: {n3}, {n1} e {n2}");
}

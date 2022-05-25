// 7.Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. A cada
// solicitação, teste se o usuário informou um valor válido.
// Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou
// se for um número), informe que ele está incorreto e saia do programa em VS. Se o nome for
// lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), informe
// que está errada e saia. Se estiver correta, solicite o salário. Se ele estiver incorreto
// (menor ou igual a zero), informe que está incorreto e saia. Se estiver correto, mostre todos
// os valores lidos.

int idade = 0;
double salario = 0;
bool estaCerto = false;
string nome;

while (true)
{
    Console.WriteLine("Digite seu nome: ");
    nome = Console.ReadLine();

    bool temNumero = false;
    char[] nomeArray = nome.ToCharArray();

    foreach (var item in nomeArray)
    {
        temNumero = char.IsNumber(item);
    }

    if (temNumero)
    {
        Console.WriteLine("Voce digitou um número no seu nome.");
        break;
    }

    Console.WriteLine("Informe sua idade: ");
    idade = int.Parse(Console.ReadLine());

    if (idade <= 0)
    {
        Console.WriteLine("idade inválida!");
        break;
    }

    Console.WriteLine("informe o seu salário: ");
    salario = int.Parse(Console.ReadLine());

    if (salario <= 0)
    {
        Console.WriteLine("salário inválido!");
        break;
    }
    estaCerto = true;
    break;
}
if (estaCerto)
{
    Console.WriteLine($"O seu nome é: {nome}.\nA idade é: {idade}\nO salário é: {salario}.");
}

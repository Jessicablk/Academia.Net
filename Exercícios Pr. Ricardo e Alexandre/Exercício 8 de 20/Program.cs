// 8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um
// funcionário. Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5%
// do total de vendas. Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário
// final 7% do total de vendas. E por fim, se o total de vendas seja maior que R$ 5000,00,
// adicionar ao seu salário final 10% do total de vendas.

int codigo;
string nome;
double salarioBase, totalVendas, comissao;

Console.WriteLine("Informe o código do funcionário: ");
codigo = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o nome do funcionário: ");
nome = Console.ReadLine();
Console.WriteLine("Informe o salário base do funcionário: ");
salarioBase = double.Parse(Console.ReadLine());
Console.WriteLine("Informe o total de vendas do funcionário: ");
totalVendas = double.Parse(Console.ReadLine());

if (totalVendas > 500.00 && totalVendas < 1000.00)
{
    comissao = salarioBase + (totalVendas * 0.05);
    Console.WriteLine("Código: " + codigo + "\nNome: " + nome + "\nSalário Total: " + comissao);
}
else if (totalVendas > 1000.00 && totalVendas < 5000.00)
        {
    comissao = salarioBase + (totalVendas * 0.07);
    Console.WriteLine("Código: " + codigo + "\nNome: " + nome + "\nSalário Total: " + comissao);
}
else if (totalVendas > 5000.00)
        {
    comissao = salarioBase + (totalVendas * 0.10);
    Console.WriteLine("Código: " + codigo + "\nNome: " + nome + "\nSalário Total: " + comissao);
}

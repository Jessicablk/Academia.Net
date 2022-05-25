/*Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu 
 * salário fixo, o total de vendas por ele efetuadas e o percentual que ganha sobre o 
 * total de vendas. Calcule o salário total do vendedor. Escreva o número do vendedor 
 * e o salário total do vendedor.*/

//parte1: ler numero do vendedor ok
//parte2: ler salario do vendedor ok
//parte3: ler o total de vendas ok
//parte4: ler o percentual que ganha sobre o total de vendas ok
//parte5: calcular o salario total (fixo+ comissão) ok
//parte6: escrever o numero do vendedor e o salario total ok

Console.WriteLine("Digite o número do vendedor: ");
int vendedor = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o salário do vendedor: ");
double salario = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor total de vendas: ");
double vendas = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o percentual de comissão do vendedor: ");
double comissao = double.Parse(Console.ReadLine());

double comissaovalor = (vendas * comissao / 100);
double salariototal = comissaovalor + salario;
Console.WriteLine($"O número do vendedor é: {vendedor} E o seu salário total é: {salariototal}");



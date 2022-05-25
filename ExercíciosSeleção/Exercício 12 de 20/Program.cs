//12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente
//código e número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se
//que ele ganha R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de
//pagamento armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente
//de trabalho vale R$ 20,00. No final do processamento, exibir o salário total e o salário
//excedente do operário.

int codigo;
double numeroHoras, extra, salario;

Console.WriteLine("Digite o código do operário: ");
codigo = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
numeroHoras = double.Parse(Console.ReadLine());
salario = numeroHoras * 10;

if (numeroHoras > 50)
{
    extra = (numeroHoras - 50) * 20.00;
    salario = 50 * 10.00;
    Console.WriteLine("Salário total: " + salario + "\nSalário excedente: " + extra);
}
else
{
    Console.WriteLine("Salário total: " + salario);
}
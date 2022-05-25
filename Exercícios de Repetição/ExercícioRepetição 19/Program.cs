// 19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, coletando dados
// sobre o salário e número de filhos. A prefeitura deseja saber: 
//a) média do salário da população;
//b) média do número de filhos;
//c) maior salário;
//d) percentual de pessoas com salário até R$ 1000,00.
//O final da leitura de dados se dará com a entrada de um salário negativo.

double mediaSalario, maiorSalario, porcentagem, salario, somaSalario, mediaFilhos;
int numfilhos, contagemPopulacao, contagemFilhos, contagemSalario1000;

contagemSalario1000 = 0;
somaSalario = 0;
maiorSalario = 0;
salario = 0;
contagemFilhos = 0;
contagemPopulacao = 0;

while (true)
{
    Console.Write("Informe o seu salário: ");
    salario = double.Parse(Console.ReadLine());
    Console.WriteLine();

    if (salario < 0)
    {
        break;
    }
    Console.Write("Informe a quantidade de filhos: ");
    numfilhos = int.Parse(Console.ReadLine());
    Console.WriteLine();

    contagemPopulacao++;
    contagemFilhos += numfilhos;
    somaSalario += salario;

    if (salario > maiorSalario)
    {
        maiorSalario = salario;
    }
    if (salario >= 0 && salario <= 1000)
    {
        contagemSalario1000++;
    }
   
   if (salario == 0 || salario >= 1001)
   {
        Console.WriteLine("Salário inválido!");
        break;
   }
    Console.WriteLine();
    
}
 
    
mediaSalario = (double) somaSalario / contagemPopulacao;

mediaFilhos = (double) contagemFilhos / contagemPopulacao;

porcentagem = (double) (contagemSalario1000 * 1) / contagemPopulacao;

Console.WriteLine("-----------------------------------------------------------------------\n" +
                  "                         Pesquisa da Prefeitura                        \n" +
                  "-----------------------------------------------------------------------\n" +
                  " [1] - Média dos salários: {0:C}\n" +
                  " [2] - Média do número de filhos: {1:F2}\n" +
                  " [3] - Maior salário: {2:C}\n" +
                  " [4] - Percentual de pessoas com salário até R$ 1000,00: {3:0%}\n" +
                  "-----------------------------------------------------------------------",mediaSalario, mediaFilhos, maiorSalario, porcentagem);


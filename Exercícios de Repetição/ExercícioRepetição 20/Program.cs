// 20. Foi realizada uma pesquisa de algumas características físicas da população de uma
// certa região, a qual coletou os seguintes dados referentes a cada habitante para serem
// analisados:
// - sexo(masculino e feminino)
// - cor dos olhos(azuis, verdes ou castanhos)
// - cor dos cabelos(louros, castanhos, pretos)
// - idade
// Faça um algoritmo que determine e escreva:
// - a maior idade dos habitantes
// - a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
// e que tenham olhos verdes e cabelos louros.
// O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.

string sexo, corOlhos, corCabelos;
int idade, maiorIdade, qntddFeminino;

maiorIdade = 0;
qntddFeminino = 0;

while (true)
{
    Console.WriteLine("Digite o seu sexo (M/F): ");
    sexo = Console.ReadLine().ToUpper();
    Console.WriteLine();

    Console.WriteLine("Informe a cor dos seus olhos (Azuis/Verdes/Castanhos: ");
    corOlhos = Console.ReadLine().ToUpper();
    Console.WriteLine();

    Console.WriteLine("Informe a cor dos seus cabelos (Loiro/Castanho/Preto): ");
    corCabelos = Console.ReadLine().ToUpper();
    Console.WriteLine();

    Console.WriteLine("Digite sua idade: ");
    idade = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (idade == -1)
    {
        break;
    }
    if (idade > maiorIdade)
    {
        maiorIdade = idade;
    }
    if (sexo == "FEMININO" && idade >= 18 && idade <= 35 && corOlhos == "VERDES" && corCabelos == "LOIRO")
    {
        qntddFeminino++;
    }
}

Console.WriteLine("----------------------------------------------------------------------------------\n" +
                  "                                 DADOS DA PESQUISA                                \n" +
                  "----------------------------------------------------------------------------------\n" +
                  " [1] - Maior idade dos habitantes: {0}\n" +
                  " [2] - Quantidade de mulheres entre 18 e 35 anos, loiras e dos olhos verdes: {1}\n" +
                  "----------------------------------------------------------------------------------", maiorIdade, qntddFeminino);


// 10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
// Número de pessoas do sexo masculino.
// Número de pessoas do sexo feminino.
// Número de pessoas com idade inferior a 30 anos.
// Número de pessoas com idade superior a 60 anos.
// Média de idade das mulheres.

string nome, sexo;
int idade, sexoM, sexoF, idadeInferior30, idadeSuperior60, somaidade;
double media;

sexoF = 0;
sexoM = 0;
idadeInferior30 = 0;
idadeSuperior60 = 0;
somaidade = 0;

for (int i = 0; i < 50; i++)
{
    Console.WriteLine("Digite seu nome: ");
    nome = Console.ReadLine();
    Console.WriteLine("Digite seu sexo (M/F): ");
    sexo = Console.ReadLine().ToUpper();
    Console.WriteLine("Digite sua idade: ");
    idade = int.Parse(Console.ReadLine());

    if (sexo == "M" || sexo == "MASCULINO")
    {
        sexoM++;
    }
    else if (sexo == "F" || sexo == "FEMININO")
    {
        sexoF++;
        somaidade += idade;
    }
    else
    {

    }
    if (idade < 30)
    {
        idadeInferior30++;
    }
    else if (idade > 60)
    {
        idadeSuperior60++;
    }
    else
    {

    }
    Console.WriteLine();
}

media = (double)somaidade / sexoF;

Console.WriteLine("--------------------------------------------------\n" +
                  "                     Contagem                     \n" +
                  "--------------------------------------------------\n" +
                  "[1] - Pessoas do sexo Masculino: "+ sexoM+"\n"+
                  "[2] - Pessoas do sexo Feminino: "+ sexoF+"\n"+
                  "[3] - Pessoas com idade inferior a 30 anos: "+ idadeInferior30+"\n"+
                  "[4] - Pessoas com idade superior a 60 anos: "+idadeSuperior60+"\n"+
                  "[5] - Média das idades das mulheres: "+ media);




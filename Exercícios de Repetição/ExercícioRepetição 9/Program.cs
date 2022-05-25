// 9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas
// que visitaram o zoológico num determinado dia, imprimindo:
// Quantas pessoas tem entre 1 e 3 filhos.
// Quantas pessoas tem entre 4 e 7 filhos.
// Quantas pessoas tem mais de 8 filhos.
// Quantas pessoas não tem filhos.

int qntdd, qntddA, qntddB, qntddC, qntddD;

qntddA = 0;
qntddB = 0;
qntddC = 0;
qntddD = 0;

for (int i = 0; i < 30 ; i++)
{
    Console.WriteLine("Quantos filhos você tem? ");
   qntdd = int.Parse(Console.ReadLine());

    if (qntdd <= 0)
    {
        qntddD++;
    }
    else if (qntdd >= 1 && qntdd <= 3)
    {
        qntddA++;
    }
    else if (qntdd >= 4 && qntdd <= 7)
    {
        qntddB++;
    }
    else
    {
        qntddC++;
    }
}

Console.WriteLine("----------------------------------------\n" +
                  "                Contagem                \n" +
                  "----------------------------------------\n" +
                  "[1] - Pessoas com 1 a 3 filhos: " + qntddA + "\n" +
                  "[2] - Pessoas com 4 a 7 filhos: " + qntddB + "\n" +
                  "[3] - Pessoas com 8 ou mais filhos: " + qntddC + "\n" +
                  "[4] - Pessoas que não tem filhos: " + qntddD + "\n" +
                  "----------------------------------------");



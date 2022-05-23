Console.WriteLine("Faça um programa em C# e no Visual Studio que receba" +
    "\ndata na forma DD/MM/AAAA e imprima na forma AAAA/MM/DD e " +
    "\nAA/MM/DD. Note que o dia, o mês e o ano devem ser lidos em variáveis ​​diferentes.");

int dia;
int mes;
int ano;

Console.WriteLine("Informe o dia: ");
dia = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o mês: ");
mes = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o ano: ");
ano = int.Parse(Console.ReadLine());

Console.WriteLine("DD/MM/AAAA: " + dia + "/" + mes + "/" + ano);
Console.WriteLine("AAAA/MM/DD: " + ano + "/" + mes + "/" + dia);

Console.WriteLine("AA/MM/DD: " + (ano % 100) + "/" + mes + "/" + dia);



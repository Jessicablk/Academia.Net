// 4 .Faça um algoritmo que leia uma lista de números inteiros positivos terminada pelo
// número 0 (zero). Ao final, o algoritmo deve mostrar a média aritmética de todos os
// números lidos (excluindo o zero).

// declarando as variaveis e lista
string numeroInf, resp;
double media;
int numero, soma, contador;
List<int> listaNumeros = new List<int>();

// atribuindo valores
soma = 0;
contador = 0;
resp = "";

// repetição até que a resposta seja a esperada para terminar a repetição
while(resp != "N")
{
    // repetição infinita para que seja realizado a inserção de pelo menos um número
    while (true)
    {
        // limpa a tela do console, imprime a mensagem na tela, lê o valor digitado e salva na variável
        Console.Clear();
        Console.Write("Digite um número inteiro terminado em zero (Ex: 10, 20, 30...): ");
        numeroInf = Console.ReadLine();
        Console.WriteLine();

        // efetua a verificação se o número digitado é inteiro e se termina com zero
        if(int.TryParse(numeroInf, out numero) && numeroInf.EndsWith("0"))
        {
            // efetua a soma dos número inteiros sem o zero final, adiciona na lista e realiza a contagem de números
            soma += (int)numero / 10;
            listaNumeros.Add(numero);
            contador++;
            break;
        }
        // verifica que o número digitado não atende as condições
        else
        {
            Console.WriteLine("Número inválido! O número não é inteiro ou não termina com zero (0).\n");
        }
        Console.Write("Digite algo para continuar.");
        Console.ReadLine();
    }
    // imprime na tela a mensagem para verificar se deseja adicionar mais um número ou não
    Console.Write("Deseja informar outro número (S/N)? ");
    resp = Console.ReadLine().ToUpper();
    Console.WriteLine();
}
// calculo da media
media = (double)soma / contador;

// imprime na tela o resultado da média
Console.WriteLine("A média aritmética dos números é: {0:F2}.", media);

// imprime da tela os números cadastrados na lista 
Console.WriteLine("A lista de números cadastrados é: ");
foreach(int i in listaNumeros)
{
    Console.WriteLine(i);
}
Console.WriteLine();
Console.WriteLine("Saindo!"); 


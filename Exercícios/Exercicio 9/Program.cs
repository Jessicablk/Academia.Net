// Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a
// entrada maior do que ou igual às duas prestações, que devem ser iguais, inteiras e
// as maiores possíveis. Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada
// e as duas prestações são iguais a R$ 90,00; se o valor da mercadoria for R$ 302,75 a
// entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00. Escreva um
// programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor
// da entrada e das duas prestações, de acordo com as regras acima.
// Observe que uma justificativa para a adoção desta regra é que ela facilita a
// confecção e o conseqüente pagamento dos boletos das duas prestações.

//Parte1: pegar o valor da compra
//Parte2: calcular o valor minimo de entrada (tem que ser maior ou igual a um terço do valor total)
//Parte3: verificar se o valor de entrada que o comprador quer pagar é equivalente ao minimo calculado
//Parte3.1: pegar o valor que o comprador quer dar de entrada
//Parte4: calcular o valor das duas parcelas

Console.WriteLine($"Digite o valor todal da compra: ");
double valorTotal = double.Parse(Console.ReadLine());
double valorDeEntradaDesejado = 0;
double parcelas = 0;
double valorMinimoEntrada = valorTotal / 3;
bool repetir = true; //bool é uma variavel que só pode armazenar dentro dela true ou false

Console.WriteLine($"Digite o valor desejado para pagar a entrada\n" +
    $"Obs: O valor mínimo de entrada é {valorMinimoEntrada}");

while (repetir)
{
    valorDeEntradaDesejado = double.Parse(Console.ReadLine());

    if (valorDeEntradaDesejado >= valorMinimoEntrada)
    {
        parcelas = (valorTotal - valorDeEntradaDesejado)/2;
        repetir = false;
    }
    else //erro
    {
        Console.WriteLine($"Valor informado inferior ao mínimo desta compra!" +
            $"Obs: O valor mínimo de entrada é {valorMinimoEntrada}");
    }
}

Console.WriteLine($"O valor total da compra é: {valorTotal} ");
Console.WriteLine($"O valor da entrada da compra é: {valorDeEntradaDesejado} ");
Console.WriteLine($"O valor das parcelas (2) é: {parcelas} ");

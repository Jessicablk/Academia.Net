//5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra
//“Aprovado” se a média das duas notas for maior ou igual a 7,0. Caso a média seja
//inferior a 7,0, o programa deve ler a nota do exame e calcular a média final, e a média
//entre a nota do exame e a média das 2 notas. Se esta média final for maior ou igual a
//5,0, o programa deve escrever “Aprovado”, caso contrário deve escrever “Reprovado”.

//declarar as variáveis 
float nota1, nota2, media, exame, mediafinal;
//imprime na tela e lê o valor digitado para guardar na variável
Console.WriteLine("Digite a primeira nota do aluno: ");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota do aluno: ");
nota2 = float.Parse(Console.ReadLine());
//calculo da média no periódo normal
media = (nota1 + nota2) / 2;

//checagem das condicionais de aprovado, exame ou reprovado
if (media >= 7.00)
{
    Console.WriteLine("Parabéns, você foi APROVADO!");
}
else
{
    Console.WriteLine("Digite a nota do exame: ");
    exame = float.Parse(Console.ReadLine());
    mediafinal = (media + exame) / 2;
    if (mediafinal >= 5.00)
    {
        Console.WriteLine("Parabéns, você foi APROVADO no exame!");
    }
    else
    {
        Console.WriteLine("Infelizmente você foi REPROVADO!");
    }

}
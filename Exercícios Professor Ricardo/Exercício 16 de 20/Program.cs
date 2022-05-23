//16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil.
//Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre na tela uma
//mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário,
//mostre uma mensagem indicando que os dois times irão se enfrentar novamente em um novo jogo.
//Ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
//Ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
//Plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.

string timeCasa, timeFora;

int golsTimeCasa, golsTimeFora;

Console.WriteLine("Time da Casa: ");
timeCasa = Console.ReadLine();
Console.WriteLine("Time visitante: ");
timeFora = Console.ReadLine();

Console.WriteLine("Gols feitos pelo time da casa: ");
golsTimeCasa = int.Parse(Console.ReadLine());
Console.WriteLine("Gols feitos pelo time visitante: ");
golsTimeFora = int.Parse(Console.ReadLine());

if (golsTimeFora > golsTimeCasa && (golsTimeFora - golsTimeCasa) >= 2)
{
    Console.WriteLine($"{timeFora} já está classificado, pois ganhou com uma diferença de 2 gols!");
}
else
{
    Console.WriteLine("Novo jogo...");

    string tmp = timeCasa;
    timeCasa = timeFora;
    timeFora = tmp;

    Console.WriteLine($"Time da casa agora é {timeCasa}");
    Console.WriteLine($"Time de fora agora é {timeFora}");

    Console.WriteLine("Gols feitos pelo time da casa: ");
    golsTimeCasa = int.Parse(Console.ReadLine());
    Console.WriteLine("Gols feitos pelo time visitante: ");
    golsTimeFora = int.Parse(Console.ReadLine());

    if (golsTimeCasa > golsTimeFora)
    {
        Console.WriteLine($"{timeCasa} passou para a próxima fase!");
    }
    else
    {
        Console.WriteLine($"{timeFora} passou para a próxima fase!");
    }

}

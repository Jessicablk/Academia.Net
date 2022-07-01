// #2
// Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de cinco animais
// de estimação. O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e
// Peixes foram informados.
// Regras que deverão ser seguidas para a implementação do programa:

// Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
// Caso seja informado um tipo diferente o programa repetir até o usuário digitar um tipo
// válido.
// É obrigatório criar uma classe para representar o Animal.
// A classe deverá possuir dois dados privados (propriedades) para representar as
// características do animal.
// A classe deverá possuir métodos de acesso (propriedade getter e setter) para permitir que
// o usuário armazene/leia os dados dos dois dados privados (propriedades).

using Exercício2;

string nome, tipo;
int qntddCachorros, qntddGatos, qntddPeixes;

Console.WriteLine("Informe o nome do animal: ");
nome = Console.ReadLine().ToUpper();
Console.WriteLine("Informe o tipo do animal (C) Cachorro, (G) Gato ou (P) Peixe): ");
tipo = Console.ReadLine().ToUpper();

while (true)
{
    if (tipo != "(C)" || tipo != "(G)" || tipo != "(P)")
    {
        Console.WriteLine("Tipo de animal inválido! Digite um tipo válido.");
    }
    break;
}

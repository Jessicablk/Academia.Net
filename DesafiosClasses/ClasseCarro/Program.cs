//Crie uma classe Carro com os atributos: modelo, marca, cor e placa. Crie um método
//para definir os atributos, outro método para ligar o carro e outro método para desligar
//o carro.

using ClasseCarro;
Console.WriteLine("Informe o modelo do carro: ");
string mod = Console.ReadLine();
Console.WriteLine("Informe a marca do carro: ");
string mar = Console.ReadLine();
Console.WriteLine("Informe a cor do carro: ");
string cr = Console.ReadLine();
Console.WriteLine("Informe a placa do carro: ");
string pl = Console.ReadLine();

Carro c = new Carro(mod, mar, cr, pl);

c.ligar();
c.desligar();




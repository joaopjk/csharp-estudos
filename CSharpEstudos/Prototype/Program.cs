using Prototype;

Console.WriteLine("Hello, World!");

var soldado = new Soldado
{
    Nome = "João",
    Arma = "Espada"
};

var soldadoClone = (Soldado)soldado.Clone();
var soldadoClone1 = (Soldado)soldado.Clone();

Console.WriteLine($"Soldado Original: {soldado.Nome} - {soldado.Arma}");
Console.WriteLine($"Soldado Clone 0: {soldadoClone.Nome} - {soldadoClone.Arma}");
Console.WriteLine($"Soldado Clone 1: {soldadoClone1.Nome} - {soldadoClone1.Arma}");

var soldadoComAcessorio = new SoldadoComAcessorio
{
    Nome = "Maria",
    Arma = "Arco e Flecha",
    Acessorio = new Acessorio { Nome = "Capacete" }
};
var soldadoComAcessorioClone = (SoldadoComAcessorio)soldadoComAcessorio.Clone();
soldadoComAcessorioClone.Acessorio.Nome = "Elmo";

Console.WriteLine($"Soldado Original: {soldadoComAcessorio.Nome} - {soldadoComAcessorio.Arma} - {soldadoComAcessorio.Acessorio.Nome}");
Console.WriteLine($"Soldado Clone 0: {soldadoComAcessorioClone.Nome} - {soldadoComAcessorioClone.Arma} - {soldadoComAcessorioClone.Acessorio.Nome}");
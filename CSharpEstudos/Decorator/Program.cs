using Decorator;
using Decorator.Decorators;

var pizzaMussarela = new Pizza("Mussarela");
Console.WriteLine(pizzaMussarela.Nome);
Console.WriteLine(pizzaMussarela.Opcionais());
Console.WriteLine("R$" + pizzaMussarela.Preco());

var massaEspecial = new MassaEspecialDecorator(pizzaMussarela);
var baconDecorator = new BaconDecorator(massaEspecial);
var bordaDecorator = new BordaRecheadaDecorator(baconDecorator);

Console.WriteLine("Preço total da Pizza: ");
Console.WriteLine(bordaDecorator.Opcionais());
Console.WriteLine("R$" + bordaDecorator.Preco());
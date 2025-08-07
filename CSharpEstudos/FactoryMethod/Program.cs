using FactoryMethod;

Console.WriteLine("======= Pizzaria =======");
Console.WriteLine("Informe o local: (SP) São Paulo | (RJ) Rio de Janeiro");
var local = Console.ReadLine()?.ToUpperInvariant();

Console.WriteLine("Informe a pizza: (C) - Calabresa | (M) - Mussarela");
var tipoPizza = Console.ReadLine()?.ToUpperInvariant();

try
{
    var pizzaria = PizzaSimpleFactory.CriarPizzaria(local!);
    var pizza = pizzaria.CriarPizza(tipoPizza!);
    Console.WriteLine(pizza.Preparar());
    Console.WriteLine("Pizza concluída com sucesso!");
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}

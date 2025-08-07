using SimpleFactory;

Console.WriteLine("======= Pizzaria =======\n");
Console.WriteLine("Informe a pizza (C) - Calabresa | (M) - Mussarela");
var pizzaEscolhida = Console.ReadLine()?.ToUpperInvariant();
try
{
    var pizza = PizzaSimpleFactory.CriarPizza(pizzaEscolhida);
    pizza.Preparar();
    pizza.Embalar();
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}

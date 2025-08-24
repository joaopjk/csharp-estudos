namespace SimpleFactory
{
    internal class PizzaSimpleFactory
    {
        public static Pizza CriarPizza(string pizza)
        {
            return pizza switch
            {
                "C" => new PizzaCalabresa(),
                "M" => new PizzaMussarela(),
                _ => throw new ArgumentException("A pizza escolhida não existe em nosso cardápio!")
            };
        }
    }
}

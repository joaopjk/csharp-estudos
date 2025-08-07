namespace FactoryMethod
{
    internal class PizzariaSaoPaulo : PizzaFactoryMethod
    {
        public override Pizza CriarPizza(string tipo)
        {
            return tipo switch
            {
                "C" => new SpPizzaCalabresa(),
                "M" => new SpPizzaMussarela(),
                _ => throw new ArgumentException("Tipo de pizza desconhecido")
            };
        }
    }
}

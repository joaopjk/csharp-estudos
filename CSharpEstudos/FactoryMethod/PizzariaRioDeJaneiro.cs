namespace FactoryMethod
{
    internal class PizzariaRioDeJaneiro : PizzaFactoryMethod
    {
        public override Pizza CriarPizza(string tipo)
        {
            return tipo switch
            {
                "C" => new RjPizzaCalabresa(),
                "M" => new RjPizzaMussarela(),
                _ => throw new ArgumentException("Tipo de pizza desconhecido")
            };
        }
    }
}

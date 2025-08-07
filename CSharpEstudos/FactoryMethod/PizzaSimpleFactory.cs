namespace FactoryMethod
{
    internal class PizzaSimpleFactory
    {
        public static PizzaFactoryMethod CriarPizzaria(string tipo)
        {
            return tipo switch
            {
                "SP" => new PizzariaSaoPaulo(),
                "RJ" => new PizzariaRioDeJaneiro(),
                _ => throw new ArgumentException("Tipo de pizzaria desconhecido")
            };
        }
    }
}

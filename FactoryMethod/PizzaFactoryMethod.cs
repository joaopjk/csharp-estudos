namespace FactoryMethod
{
    internal abstract class PizzaFactoryMethod
    {
        public Pizza MontarPizza(string tipo)
        {
            return CriarPizza(tipo);
        }

        public abstract Pizza CriarPizza(string tipo);
    }
}

namespace Decorator.Decorators
{
    internal abstract class PizzaDecorator(IPizza pizza) : IPizza
    {
        protected readonly IPizza Pizza = pizza;
        public virtual string Opcionais()
        {
            return Pizza.Opcionais();
        }

        public virtual decimal Preco()
        {
            return Pizza.Preco();
        }
    }
}

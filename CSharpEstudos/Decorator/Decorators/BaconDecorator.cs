namespace Decorator.Decorators
{
    internal class BaconDecorator(IPizza pizza) : PizzaDecorator(pizza)
    {
        public override string Opcionais()
        {
            var opcional = base.Opcionais();
            opcional += "\r\n com Bacon Especial";
            return opcional;
        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 15.00m;
            return preco;
        }
    }
}

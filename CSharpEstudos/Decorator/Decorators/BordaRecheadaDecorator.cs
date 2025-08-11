namespace Decorator.Decorators
{
    internal class BordaRecheadaDecorator(IPizza pizza) : PizzaDecorator(pizza)
    {
        public override string Opcionais()
        {
            var opcional = base.Opcionais();
            opcional += "\r\n com Borda Recheada Especial";
            return opcional;
        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 4.00m;
            return preco;
        }
    }
}

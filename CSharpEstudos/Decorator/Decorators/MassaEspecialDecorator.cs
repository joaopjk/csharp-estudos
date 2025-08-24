namespace Decorator.Decorators
{
    internal class MassaEspecialDecorator(IPizza pizza) : PizzaDecorator(pizza)
    {
        public override string Opcionais()
        {
            var opcional = base.Opcionais();
            opcional += "\r\n com Massa Especial";
            return opcional;
        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 5.00m;
            return preco;
        }
    }
}

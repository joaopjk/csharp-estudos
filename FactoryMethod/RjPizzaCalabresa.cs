namespace FactoryMethod
{
    internal class RjPizzaCalabresa : Pizza
    {
        public RjPizzaCalabresa()
        {
            Nome = "Pizza de Calabresa Carioca";
            Massa = "Massa fina crocante Carioca";
            Molho = "Molho de tomate fresco com manjericão Carioca";
            Ingredientes.Add("Queijo Parmesão");
            Ingredientes.Add("Azeitonas verdes");
        }
    }
}

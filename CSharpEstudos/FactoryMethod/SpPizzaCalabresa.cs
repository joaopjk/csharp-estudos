namespace FactoryMethod
{
    internal class SpPizzaCalabresa : Pizza
    {
        public SpPizzaCalabresa()
        {
            Nome = "Pizza de Calabresa de São Paulo";
            Massa = "Massa fina crocante Paulista";
            Molho = "Molho de tomate fresco com manjericão Paulista";
            Ingredientes.Add("Queijo Parmesão");
            Ingredientes.Add("Azeitonas verdes");
        }
    }
}

namespace FactoryMethod
{
    internal class SpPizzaMussarela : Pizza
    {
        public SpPizzaMussarela()
        {
            Nome = "Pizza de Mussarela de São Paulo";
            Massa = "Massa fina crocante Paulista";
            Molho = "Molho de tomate fresco com manjericão Paulista";
            Ingredientes.Add("Queijo Parmesão");
            Ingredientes.Add("Azeitonas verdes");
        }
    }
}

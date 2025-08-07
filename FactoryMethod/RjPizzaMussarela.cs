namespace FactoryMethod
{
    internal class RjPizzaMussarela : Pizza
    {
        public RjPizzaMussarela()
        {
            Nome = "Pizza de Mussarela Carioca";
            Massa = "Massa fina crocante Carioca";
            Molho = "Molho de tomate fresco com manjericão Carioca";
            Ingredientes.Add("Queijo Parmesão");
            Ingredientes.Add("Azeitonas verdes");
        }
    }
}

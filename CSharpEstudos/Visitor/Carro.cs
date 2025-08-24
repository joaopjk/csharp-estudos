namespace Visitor
{
    internal class Carro : ILoja
    {
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public decimal Preco { get; set; }

        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }
}

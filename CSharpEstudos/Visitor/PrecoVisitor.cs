namespace Visitor
{
    internal class PrecoVisitor : IVisitor
    {
        private const int CarroNovoDesconto = 10;
        public void Accept(Carro carro)
        {
            var precoCarroAposDesconto = carro.Preco - ((carro.Preco/100) * CarroNovoDesconto);
            Console.WriteLine($"{carro.Nome} - {carro.Modelo} - Novo preço: R${precoCarroAposDesconto}");
        }
    }
}

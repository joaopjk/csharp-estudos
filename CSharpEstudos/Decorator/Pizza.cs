namespace Decorator
{
    internal class Pizza(string nome) : IPizza
    {
        public string Nome { get; } = nome;
        public string Opcionais()
        {
            return $"Pizza de {Nome}";
        }

        public decimal Preco()
        {
            return 10.00m;
        }
    }
}

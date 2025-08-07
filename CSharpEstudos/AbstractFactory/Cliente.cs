namespace AbstractFactory
{
    internal class Cliente(IMontadora factory)
    {
        private readonly ISuv _suv = factory.CriarSuv();
        private readonly ISedan _sedan = factory.CriarSedan();

        public string GetSuvDetalhes() => _suv.ExibirDetalhes();
        public string GetSedanDetalhes() => _sedan.ExibirDetalhes();
    }
}

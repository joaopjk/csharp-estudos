namespace Facade
{
    internal class Cliente(string nome)
    {
        public string Nome { get; private set; } = nome;
    }
}

namespace Proxy
{
    internal class Funcionario(string nome, string perfil)
    {
        public string Nome { get; set; } = nome;
        public string Perfil { get; set; } = perfil;
    }
}

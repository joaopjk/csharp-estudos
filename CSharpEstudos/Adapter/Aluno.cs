namespace Adapter
{
    internal class Aluno(int id, string nome, decimal mensalidade)
    {
        public int Id { get; set; } = id;
        public string Nome { get; set; } = nome;
        public decimal Mensalidade { get; set; } = mensalidade;
    }
}

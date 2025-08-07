namespace Adapter
{
    internal class SistemaMensalidade
    {
        public void CalcularMensalidade(List<Aluno> listaAlunos)
        {
            foreach (var aluno in listaAlunos)
            {
                var mensalidade = aluno.Mensalidade * 1.1M;
                Console.WriteLine($"Aluno: {aluno.Nome} - Valor mensalidade: R${mensalidade}");
            }
        }
    }
}

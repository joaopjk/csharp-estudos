namespace Bridge
{
    internal class GerarJson : IGerarArquivo
    {
        public void GerarArquivo(Funcionario funcionario)
        {
            Console.WriteLine($"Dados do funcionário: {funcionario.Nome} no formato JSON");
        }
    }
}

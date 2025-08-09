namespace Bridge
{
    internal class GerarXml : IGerarArquivo
    {
        public void GerarArquivo(Funcionario funcionario)
        {
            Console.WriteLine($"Dados do funcionário: {funcionario.Nome} no formato XML");
        }
    }
}

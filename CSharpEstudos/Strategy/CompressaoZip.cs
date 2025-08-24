namespace Strategy
{
    internal class CompressaoZip : ICompressao
    {
        public void Comprimir(string nomeArquivo)
        {
            Console.WriteLine($"Comprimindo {nomeArquivo} usando Zip.");
        }
    }
}

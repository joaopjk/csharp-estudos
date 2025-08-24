namespace Strategy
{
    internal class CompressaoGzip : ICompressao
    {
        public void Comprimir(string nomeArquivo)
        {
            Console.WriteLine($"Comprimindo {nomeArquivo} usando Gzip.");
        }
    }
}

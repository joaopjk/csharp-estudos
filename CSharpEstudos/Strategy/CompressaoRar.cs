namespace Strategy
{
    internal class CompressaoRar : ICompressao
    {
        public void Comprimir(string nomeArquivo)
        {
            Console.WriteLine($"Comprimindo {nomeArquivo} usando RAR.");
        }
    }
}

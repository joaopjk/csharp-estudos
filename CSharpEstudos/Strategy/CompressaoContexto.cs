namespace Strategy
{
    internal class CompressaoContexto(ICompressao compressao)
    {
        private ICompressao _compressao = compressao;

        public void DefineStrategy(ICompressao compressao)
        {
            _compressao = compressao;
        }

        public void ComprimirArquivo(string nomeArquivo)
        {
            _compressao.Comprimir(nomeArquivo);
        }
    }
}

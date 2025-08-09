namespace Bridge
{
    // Abstraction
    internal abstract class Arquivo(IGerarArquivo gerarArquivo)
    {
        protected IGerarArquivo GerarArquivo = gerarArquivo;

        public virtual void GravarArquivo(Funcionario funcionario)
        {
            GerarArquivo.GerarArquivo(funcionario);
        }
    }
}

namespace TemplateMethod
{
    internal abstract class VideoPlayer
    {
        public void ExecutarVideo()
        {
            CarregarArquivo();
            DecodificarVideo();
            IniciarExecucao();
        }

        public void CarregarArquivo()
        {
            Console.WriteLine("Arquivo de vídeo carregado...");
        }

        public abstract void DecodificarVideo();

        public void IniciarExecucao()
        {
            Console.WriteLine("O vídeo iniciou a execução///");
        }
    }
}

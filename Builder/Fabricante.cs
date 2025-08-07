namespace Builder
{
    internal class Fabricante
    {
        public void Build(ComputadorBuilder computadorBuilder)
        {
            computadorBuilder.BuildDispositivo();
            computadorBuilder.BuildSistemaOperacional();
        }
    }
}

namespace Builder
{
    internal abstract class ComputadorBuilder(Computador tipoComputador)
    {
        public abstract void BuildSistemaOperacional();
        public abstract void BuildDispositivo();
        private Computador TipoComputador { get; } = tipoComputador;
    }
}

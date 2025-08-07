namespace Builder
{
    internal class DesktopBuilder() : ComputadorBuilder(Computador)
    {
        private static readonly Computador Computador = new("Desktop");
        public override void BuildSistemaOperacional() => Console.WriteLine("Build Sistema Operacional no Desktop...");
        public override void BuildDispositivo() => Console.WriteLine("Build Dispositivo no Desktop...");
    }
}

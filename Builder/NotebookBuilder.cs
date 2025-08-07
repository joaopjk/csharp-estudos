namespace Builder
{
    internal class NotebookBuilder() : ComputadorBuilder(Computador)
    {
        private static readonly Computador Computador = new("Notebook");
        public override void BuildSistemaOperacional() => Console.WriteLine("Build Sistema Operacional no Notebook...");
        public override void BuildDispositivo() => Console.WriteLine("Build Dispositivo no Notebook...");
    }
}

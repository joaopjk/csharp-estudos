namespace Command
{
    internal class Pedido(Chef chef, string acao) : Comando
    {
        private Chef Chef { get; set; } = chef;
        private string Acao { get; set; } = acao;

        public override void Execute()
        {
            if ("Prato".Equals(Acao))
                this.Chef.PreparandoPrato();
            else
                this.Chef.PreparandoSobremesa();
        }
    }
}

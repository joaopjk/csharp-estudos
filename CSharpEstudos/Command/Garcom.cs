namespace Command
{
    internal class Garcom(Pedido pedido)
    {
        private Pedido Pedido { get; set; } = pedido;
        public void Executa()
        {
            Pedido.Execute();
        }
    }
}

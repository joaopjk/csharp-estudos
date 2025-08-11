namespace Proxy
{
    internal class PastaCompartilhadaProxy(Funcionario funcionario) : IPastaCompartilhada
    {
        private IPastaCompartilhada _pastaCompartilhada;

        public void OperacaoLeituraGravacao()
        {
            if (funcionario?.Perfil?.ToUpper() == "CEO")
            {
                _pastaCompartilhada = new PastaCompartilhada();
                _pastaCompartilhada.OperacaoLeituraGravacao();
            }
            else
            {
                Console.WriteLine("Você não tem permissão para acessar essa pasta");
            }
        }
    }
}

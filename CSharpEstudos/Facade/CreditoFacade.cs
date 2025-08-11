using Facade.Subsistemas;

namespace Facade
{
    internal class CreditoFacade
    {
        private readonly LimiteCredito _limiteCredito = new();
        private readonly Serasa _serasa = new();
        private readonly Cadin _cadin = new();
        private readonly Cadastro _cadastro = new();

        public void SolicitarCredito(Cliente cliente)
        {
            Console.WriteLine("Iniciando solicitação de crédito...");
            if (_serasa.EstaNoSerasa(cliente))
            {
                Console.WriteLine("Cliente está no SERASA. Crédito negado.");
                return;
            }
            if (_cadin.EstaNoCadin(cliente))
            {
                Console.WriteLine("Cliente está no CADIN. Crédito negado.");
                return;
            }
            if (!_limiteCredito.TemLimite(cliente))
            {
                Console.WriteLine("Cliente não possui limite de crédito. Crédito negado.");
                return;
            }
            _cadastro.Cadastrar(cliente);
            Console.WriteLine("Crédito aprovado para o cliente " + cliente.Nome);
        }
    }
}

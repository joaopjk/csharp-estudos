namespace Facade.Subsistemas
{
    internal class LimiteCredito
    {
        public bool TemLimite(Cliente cliente)
        {
            Console.WriteLine("Verificando limite de crédito do cliente " + cliente.Nome);
            // Simula a verificação de limite de crédito
            return true; // Assume que o cliente tem limite de crédito
        }
    }
}

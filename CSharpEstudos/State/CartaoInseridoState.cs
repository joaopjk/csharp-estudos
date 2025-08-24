namespace State
{
    internal class CartaoInseridoState : ICaixaEletronicoState
    {
        public void InserirCartao()
        {
            Console.WriteLine("Operação inválida. O cartão já foi inserido.");
        }

        public void EjetarCartao()
        {
            Console.WriteLine("O cartão foi ejetado com sucesso.");
        }

        public void InserirSenha()
        {
            Console.WriteLine("A senha foi inserida com sucesso.");
        }

        public void SacarDinheiro()
        {
            Console.WriteLine("O saque foi realizado com sucesso");
        }
    }
}

namespace State
{
    internal class CartaoNaoInseridoState : ICaixaEletronicoState
    {
        public void InserirCartao()
        {
            Console.WriteLine("Cartão inserido com sucesso.");
        }

        public void EjetarCartao()
        {
            Console.WriteLine("Não é possível ejetar o cartão. O cartão não foi inserido.");
        }

        public void InserirSenha()
        {
            Console.WriteLine("Não é possível informar a senha. Insira o cartão.");
        }

        public void SacarDinheiro()
        {
            Console.WriteLine("Não é possível sacar dinheiro. Insira o cartão.");
        }
    }
}

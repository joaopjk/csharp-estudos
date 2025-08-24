namespace State
{
    internal class CaixaEletronico : ICaixaEletronicoState
    {
        public ICaixaEletronicoState CaixaEletronicoState { get; set; } = new CartaoNaoInseridoState();

        public void InserirCartao()
        {
            CaixaEletronicoState.InserirCartao();

            if (CaixaEletronicoState is CartaoNaoInseridoState)
            {
                CaixaEletronicoState = new CartaoInseridoState();
                Console.WriteLine($"O estado interno do caixa eletrônico foi alterado para: {CaixaEletronicoState.GetType().Name}");
            }
        }

        public void EjetarCartao()
        {
            CaixaEletronicoState.EjetarCartao();

            if (CaixaEletronicoState is CartaoInseridoState)
            {
                CaixaEletronicoState = new CartaoNaoInseridoState();
                Console.WriteLine($"O estado interno do caixa eletrônico foi alterado para: {CaixaEletronicoState.GetType().Name}");
            }
        }

        public void InserirSenha()
        {
            CaixaEletronicoState.InserirSenha();
        }

        public void SacarDinheiro()
        {
            CaixaEletronicoState.SacarDinheiro();
        }
    }
}

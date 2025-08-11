namespace ChainOfResponsibility
{
    internal class GerenteProjeto : Autorizador
    {
        public override void AutorizarLicenca(string nome, int dias)
        {
            const int alcadaDias = 5;

            if (dias <= alcadaDias)
                AprovarLicenca(nome, dias);
            else
                _autorizador?.AutorizarLicenca(nome, dias);
        }

        private static void AprovarLicenca(string nome, int dias)
        {
            Console.WriteLine($"O Gerente de Projeto aprovou {dias} dias de licença remunerada para: {nome}");
        }
    }
}

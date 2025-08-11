namespace ChainOfResponsibility
{
    internal class SupervisorEquipe : Autorizador
    {
        public override void AutorizarLicenca(string nome, int dias)
        {
            const int alcadaDias = 15;

            if (dias <= alcadaDias)
                AprovarLicenca(nome, dias);
            else
                _autorizador?.AutorizarLicenca(nome, dias);
        }

        private static void AprovarLicenca(string nome, int dias)
        {
            Console.WriteLine($"O Supervisor de Equipe aprovou {dias} dias de licença remunerada para: {nome}");
        }
    }
}

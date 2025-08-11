namespace ChainOfResponsibility
{
    internal class SetorRh : Autorizador
    {
        public override void AutorizarLicenca(string nome, int dias)
        {
            const int alcadaDias = 30;

            if (dias <= alcadaDias)
                AprovarLicenca(nome, dias);
            else
                Console.WriteLine($"Não foi possível autorizar a licença de {dias} para {nome}. Comunique a Diretória");
        }

        private static void AprovarLicenca(string nome, int dias)
        {
            Console.WriteLine($"O Setor de RH aprovou {dias} dias de licença remunerada para: {nome}");
        }
    }
}

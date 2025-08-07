namespace FluentBuilder
{
    internal class EmailFluentBuilder
    {
        private readonly Email _email = new();

        public EmailFluentBuilder To(string destino)
        {
            _email.To = destino;
            return this;
        }

        public EmailFluentBuilder From(string remetente)
        {
            _email.From = remetente;
            return this;
        }

        public EmailFluentBuilder Subject(string assunto)
        {
            _email.Subject = assunto;
            return this;
        }

        public EmailFluentBuilder Body(string corpo)
        {
            _email.Body = corpo;
            return this;
        }
    }
}

namespace FluentBuilder
{
    internal class EmailBuilder
    {
        private readonly Email _email = new();

        public void To(string destino)
        {
            _email.To = destino;
        }

        public void From(string remetente)
        {
            _email.From = remetente;
        }

        public void Subject(string assunto)
        {
            _email.Subject = assunto;
        }

        public void Body(string corpo)
        {
            _email.Body = corpo;
        }

        public Email Build()
        {
            return _email;
        }
    }
}

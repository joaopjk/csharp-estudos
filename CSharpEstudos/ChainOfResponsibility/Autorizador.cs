namespace ChainOfResponsibility
{
    internal abstract class Autorizador
    {
        // ReSharper disable once InconsistentNaming
        protected Autorizador _autorizador;

        public void ProximoAutorizador(Autorizador autorizador)
        {
            _autorizador = autorizador;
        }
        public abstract void AutorizarLicenca(string nome, int dias);
    }
}

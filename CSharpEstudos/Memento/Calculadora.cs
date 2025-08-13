namespace Memento
{
    internal class Calculadora : ICalculadora
    {
        private int _primeiroNumero;
        private int _segundoNumero;
        public ICaretaker BackupUltimoCalculo()
        {
            return new MementoClass(_primeiroNumero, _segundoNumero);
        }

        public void RestaurarUltimoCalculo(ICaretaker memento)
        {
            _primeiroNumero = ((MementoClass)memento).GetPrimeiroNumero();
            _segundoNumero = ((MementoClass)memento).GetSegundoNumero();
        }

        public int GetCalculoResultado()
        {
            return _primeiroNumero + _segundoNumero;
        }

        public void SetPrimeiroNumero(int num)
        {
            _primeiroNumero = num;
        }

        public void SetSegundoNumero(int num)
        {
            _segundoNumero = num;
        }
    }
}

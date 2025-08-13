namespace Memento
{
    internal class MementoClass(int primeiroNumero, int segundoNumero) : ICaretaker, IOriginator
    {
        private readonly int _primeiroNumero = primeiroNumero;
        private readonly int _segundoNumero = segundoNumero;

        public int GetPrimeiroNumero()
        {
            return _primeiroNumero;
        }

        public int GetSegundoNumero()
        {
            return _segundoNumero;
        }
    }
}

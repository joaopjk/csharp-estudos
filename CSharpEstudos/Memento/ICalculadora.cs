namespace Memento
{
    internal interface ICalculadora
    {
        ICaretaker BackupUltimoCalculo();
        void RestaurarUltimoCalculo(ICaretaker memento);
        int GetCalculoResultado();
        void SetPrimeiroNumero(int num);
        void SetSegundoNumero(int num);
    }
}

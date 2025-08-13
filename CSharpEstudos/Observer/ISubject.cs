namespace Observer
{
    internal interface ISubject
    {
        void RegistarObserver(IObserver observer);
        void RemoverObserver(IObserver observer);
        void NotificarObservers();
    }
}

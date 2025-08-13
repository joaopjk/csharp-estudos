namespace Observer
{
    internal class ConcreteSubject(string produto, double preco, string status) : ISubject
    {
        private readonly List<IObserver> _observers = [];
        private string Produto { get; set; } = produto;
        private double Preco { get; set; } = preco;
        private string Disponibilidade { get; set; } = status;
        public string GetDisponibilidade() => Disponibilidade;
        public void SetDisponibilidade(string status)
        {
            Disponibilidade = status;
            Console.WriteLine("A disponibilidade mudou de 'Sem Estoque' para 'Disponível'");
            NotificarObservers();
        }
        public void RegistarObserver(IObserver observer)
        {
            Console.WriteLine($"Observer Adicionado: {((ConcreteObserver)observer).Usuario}");
            _observers.Add(observer);
        }

        public void RemoverObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotificarObservers()
        {
            Console.WriteLine("Notificar Observers");
            foreach (var observer in _observers)
            {
                observer.Atualizar(Disponibilidade);
            }
        }
    }
}

namespace Observer
{
    internal class ConcreteObserver: IObserver
    {
        public string Usuario { get; set; }

        public ConcreteObserver(string nome, ISubject subject)
        {
            Usuario = nome;
            subject.RegistarObserver(this);
        }
        public void Atualizar(string disponibilidade)
        {
            Console.WriteLine($"Olá {Usuario}, o produto que você deseja esta {disponibilidade} em nosso site!");
        }
    }
}

namespace Iterator
{
    internal class Iterador(ConcreteCollection concreteCollection) : IAbstractIterator
    {
        private int _current = 0;
        private const int Step = 1;

        public Cliente First()
        {
            _current = 0;
            return concreteCollection.GetCliente(_current);
        }

        public Cliente Next()
        {
            _current += Step;
            return !IsDone() ? concreteCollection.GetCliente(_current) : null;
        }

        public bool IsDone()
        {
            return _current >= concreteCollection.Count;
        }
    }
}

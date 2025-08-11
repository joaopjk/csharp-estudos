namespace Iterator
{
    internal class ConcreteCollection : IAbstractCollection
    {
        private readonly List<Cliente> _listaClientes = [];
        public Iterador CreateIterator()
        {
            return new Iterador(this);
        }
        public int Count => _listaClientes.Count;
        public void AddCliente(Cliente cliente) => _listaClientes.Add(cliente);
        public Cliente GetCliente(int index) => _listaClientes[index];
    }
}

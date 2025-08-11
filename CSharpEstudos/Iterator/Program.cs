using Iterator;

var colecao = new ConcreteCollection();
colecao.AddCliente(new Cliente("1", "Cliente 1"));
colecao.AddCliente(new Cliente("2", "Cliente 2"));
colecao.AddCliente(new Cliente("3", "Cliente 3"));

var iterador = colecao.CreateIterator();

for (var cliente = iterador.First(); !iterador.IsDone(); cliente = iterador.Next())
{
    Console.WriteLine($"ID: {cliente.Id} - Nome: {cliente.Nome}");
}

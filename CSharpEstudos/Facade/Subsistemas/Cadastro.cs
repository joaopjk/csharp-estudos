namespace Facade.Subsistemas
{
    internal class Cadastro
    {
        public void Cadastrar(Cliente cliente)
        {
            Console.WriteLine($"Cliente {cliente.Nome} cadastrado com sucesso.");
        }
    }
}

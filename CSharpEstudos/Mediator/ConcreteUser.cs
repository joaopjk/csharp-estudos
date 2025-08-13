namespace Mediator
{
    internal class ConcreteUser(IFacebookGroupMediator mediator, string name) : User(mediator, name)
    {
        public override void Send(string msg)
        {
            Console.WriteLine($"{Name}: enviada => {msg}");
            Mediator.SendMessage(msg, this);
        }

        public override void Receive(string msg)
        {
            Console.WriteLine($"{Name}: recebida <= {msg}");
        }
    }
}

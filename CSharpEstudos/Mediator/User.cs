namespace Mediator
{
    internal abstract class User(IFacebookGroupMediator mediator, string name)
    {
        protected IFacebookGroupMediator Mediator = mediator;
        protected string Name = name;
        public abstract void Send(string msg);
        public abstract void Receive(string msg);
    }
}

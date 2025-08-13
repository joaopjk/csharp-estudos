namespace Mediator
{
    internal class ConcreteFacebookGrouMediator : IFacebookGroupMediator
    {
        private readonly List<User> _users = [];

        public void SendMessage(string msg, User user)
        {
            foreach (var u in _users)
            {
                if (u != user)
                    u.Receive(msg);
            }
        }

        public void RegisterUser(User user)
        {
            _users.Add(user);
        }
    }
}

namespace SingletonStatic
{
    internal sealed class Singleton
    {
        private Singleton() { }
        static Singleton()
        {
            Instance = new Singleton();
        }

        public static Singleton Instance { get; }
    }
}

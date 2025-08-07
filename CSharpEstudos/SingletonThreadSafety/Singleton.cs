namespace SingletonThreadSafety
{
    internal class Singleton
    {
        private static Singleton _instance;
        private static int _contador = 0;
        private static readonly Lock Lock = new Lock();

        private Singleton()
        {
            _contador++;
            Console.WriteLine($"Instância: {_contador}");
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (Lock)
                {
                    return _instance ??= new Singleton();
                }
            }
        }
    }
}

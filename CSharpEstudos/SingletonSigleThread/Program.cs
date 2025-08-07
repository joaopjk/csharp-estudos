using SingletonSigleThread;

var s1 = Singleton.Instance;
var s2 = Singleton.Instance;

if(s1 == s2)
    Console.WriteLine("Existem somente uma instância");
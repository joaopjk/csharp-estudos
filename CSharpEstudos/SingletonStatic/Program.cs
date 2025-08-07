using SingletonStatic;


Parallel.Invoke(
    AcessoThread1,
    AcessoThread2,
    AcessoThread3
);

static void AcessoThread1()
{
    var s1 = Singleton.Instance;
    Console.WriteLine("Thread 1");
}

static void AcessoThread2()
{
    var s2 = Singleton.Instance;
    Console.WriteLine("Thread 2");
}

static void AcessoThread3()
{
    var s2 = Singleton.Instance;
    Console.WriteLine("Thread 3");
}
namespace Iterator
{
    internal interface IAbstractIterator
    {
        Cliente First();
        Cliente Next();
        bool IsDone();
    }
}

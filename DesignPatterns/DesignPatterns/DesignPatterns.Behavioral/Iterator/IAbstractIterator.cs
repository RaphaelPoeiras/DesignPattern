namespace DesignPatterns.Behavioral.Iterator
{
    public interface IAbstractIterator
    {
        bool IsDone { get; }
        Cliente First();
        Cliente Next();
    }
}
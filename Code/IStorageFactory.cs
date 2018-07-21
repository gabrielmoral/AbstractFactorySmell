namespace Code
{
    public interface IStorageFactory
    {
        IStorage Resolve(string storage);
    }
}
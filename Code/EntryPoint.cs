namespace Code
{
    public class EntryPoint : IEntryPoint
    {
        private readonly IStorageFactory _factory;

        public EntryPoint(IStorageFactory factory)
        {
            _factory = factory;
        }
        
        public string Start(string storageType, int number)
        {
            // In this point it looks like we have only IStorageFactory as a dependency but
            // IStorage is a dependency as well, although not injected into the constructor.
            // The reason of the code smell is that always we introduce an Abstract factory
            // we increase the number of dependencies a consumer has.
            var storage = _factory.Resolve(storageType);
            
            return storage.Save(number);
        }
    }
}
using System.ComponentModel;
using Code;
using Code.Adaprters;
using IContainer = StructureMap.IContainer;

namespace Console
{
    public class StorageAbstractFactory : IStorageFactory
    {
        private readonly IContainer _container;

        public StorageAbstractFactory(IContainer container)
        {
            _container = container;
        }
        
        public IStorage Resolve(string storage)
        {
            switch (storage)
            {
                    case "sql":
                        return _container.GetInstance<SqlStorage>();
                    case "other":
                        return _container.GetInstance<OtherStorage>();
                    default:
                        throw new InvalidEnumArgumentException();
                        
            }
        }
    }
}
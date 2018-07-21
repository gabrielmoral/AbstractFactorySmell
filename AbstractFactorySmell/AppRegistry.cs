using Code;
using StructureMap;

namespace Console
{
    public class AppRegistry : Registry
    {
        public AppRegistry()
        {
            For<IStorageFactory>().Use<StorageAbstractFactory>();
            For<IEntryPoint>().Use<EntryPoint>();
        }
    }
}
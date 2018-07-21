using System.Collections;
using System.Collections.Generic;
using Code;
using Code.Adaprters;
using StructureMap;

namespace Console
{
    public class AppRegistry : Registry
    {
        public AppRegistry()
        {
            var storageTypes = new Dictionary<string, IStorage>()
            {
                ["sql"] = new SqlStorage(),
                ["other"] = new OtherStorage()
            };
            
            For<IDictionary<string, IStorage>>().Use(storageTypes);
            For<IStorageCalculator>().Use<StorageCalculator>();
            For<IEntryPoint>().Use<EntryPoint>();
        }
    }
}
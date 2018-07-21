using System;
using Code;
using StructureMap;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container(c => { c.AddRegistry<AppRegistry>(); });
            var entryPoint = container.GetInstance<IEntryPoint>();

            var storage = Storage();
            
            var result = entryPoint.Start(storage, 1000);
            
            System.Console.WriteLine(result);
        }

        private static string Storage()
        {
            var storages = new[] {"sql", "other"};
            var randomStorage = new Random().Next(0, 2);

            return storages[randomStorage];
        }
    }
}
using System;
using System.Collections.Generic;

namespace Code
{
    public class StorageCalculator : IStorageCalculator
    {
        private readonly IDictionary<string, IStorage> _storages;

        public StorageCalculator(IDictionary<string, IStorage> storages)
        {
            _storages = storages;
        }
        
        public string Calculate(string storageType, int number)
        {
            if (!_storages.ContainsKey(storageType))
            {
                throw new ArgumentOutOfRangeException();
            }

            var storage = _storages[storageType];

            return storage.Save(number);
        }
    }
}
namespace Code
{
    public class EntryPoint : IEntryPoint
    {
        private readonly IStorageCalculator _storageCalculator;

        public EntryPoint(IStorageCalculator storageCalculator)
        {
            _storageCalculator = storageCalculator;
        }
        
        public string Start(string storageType, int number)
        {
            //Removing the abstract factory we have decreased the number of
            //dependencies of the consumer, therefore it will be easier to 
            //unit test and mantain.
            
            var result = _storageCalculator.Calculate(storageType, number);

            return result;
        }
    }
}
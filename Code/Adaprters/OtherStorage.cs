namespace Code.Adaprters
{
    public class OtherStorage : IStorage
    {
        public string Save(int number)
        {
            return $"Number {number} saved with {nameof(OtherStorage)}";
        }
    }
}
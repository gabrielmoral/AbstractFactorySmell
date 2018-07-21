namespace Code.Adaprters
{
    public class SqlStorage : IStorage
    {
        public string Save(int number)
        {
            return $"Number {number} saved with {nameof(SqlStorage)}";
        }
    }
}
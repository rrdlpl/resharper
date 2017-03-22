namespace ReSharper101WCF
{
    public interface IAnotherService
    {
        string GetData(int value);
    }

    public class AnotherService : IAnotherService
    {
        public string GetData(int value)
        {
            return $"You entered: {value}";
        }
    }
}
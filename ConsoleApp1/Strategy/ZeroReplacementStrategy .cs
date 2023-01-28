namespace ConsoleApp1.Strategy;

public class ZeroReplacementStrategy : IReplacementStrategy
{
    public string Replace(string input)
    {
        return input.Replace('0', '*');
    }
}
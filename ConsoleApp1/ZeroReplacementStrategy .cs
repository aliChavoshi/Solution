namespace ConsoleApp1;

public class ZeroReplacementStrategy : IReplacementStrategy
{
    public string Replace(string input)
    {
        return input.Replace('0', '*');
    }
}
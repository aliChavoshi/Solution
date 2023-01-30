using System.Text;

namespace ConsoleApp1.Strategy;

public class ZeroReplacementStrategy : IReplacementStrategy
{
    private readonly Dictionary<char, char> _replaceDictionary = new()
    {
        { '0', '*' },
        { '1', '1' },
        { '2', '2' },
        { '3', '3' },
        { '4', '4' },
        { '5', '5' },
        { '6', '6' },
        { '7', '7' },
        { '8', '8' },
        { '9', '9' }
    };

    public string Replace(string input)
    {
        var result = Replace(input.ToCharArray(), 0, input.Length, new StringBuilder());
        return result;
    }

    private string Replace(IReadOnlyList<char> input, int index, int count, StringBuilder result)
    {
        try
        {
            var unused = result.Length / count;
            var value = _replaceDictionary[input[index]];
            return Replace(input, index + 1, --count, result.Append(value));
        }
        catch (DivideByZeroException e)
        {
            return result.ToString();
        }
        catch (KeyNotFoundException e)
        {
            Console.WriteLine("please just write number.");
            throw;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
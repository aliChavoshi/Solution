using System.Text;

namespace ConsoleApp1.Dictionary;

public class ReplaceCharacter
{
    private readonly Dictionary<char, char> _replaceDictionary;

    public ReplaceCharacter()
    {
        _replaceDictionary = new Dictionary<char, char>
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
            { '9', '9' },
        };
    }

    public string Replace(string input)
    {
        var result = new StringBuilder();
        Replace(input.ToCharArray(), 0, result);
        return result.ToString();
    }

    private void Replace(IReadOnlyList<char> input, int index, StringBuilder result)
    {
        try
        {
            if (result.Length == input.Count) return;
            _replaceDictionary.TryGetValue(input[index], out char value);
            Replace(input, index + 1, result.Append(value));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
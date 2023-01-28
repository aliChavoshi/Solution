namespace ConsoleApp1.Dictionary;

public class ReplaceCharacter
{
    private readonly Dictionary<char, char> _replaceDictionary;

    public ReplaceCharacter()
    {
        _replaceDictionary = new Dictionary<char, char> { { '0', '*' } };
    }

    public string Replace(string input)
    {
        return Replace(input.ToCharArray(), 0);
    }

    private string Replace(char[] input, int index)
    {
        //close iteration
        if (index == input.Length) return new string(input);
        //validation
        if (!char.IsNumber(input[index])) throw new Exception("input is not a number");
        //replace
        if (_replaceDictionary.ContainsKey(input[index]))
            input[index] = _replaceDictionary[input[index]];
        //iteration
        Replace(input, index + 1);
        //return value
        return new string(input);
    }
}
using System.Text;

namespace ConsoleApp1.Strategy;

public class ZeroReplacementStrategy : IReplacementStrategy
{
    public string Replace(string input)
    {
        return Replace(input.ToCharArray(), 0, new StringBuilder());
    }

    private static string Replace(char[] input, int index, StringBuilder sb)
    {

        //
        if (index == input.Length) return new string(input);
        var value = input[index];
        //validation
        if (!char.IsNumber(value)) throw new Exception("input is not a number");
        sb.Append(value == '0' ? '*' : value);
        Replace(input, index + 1, sb);
        return sb.ToString();
    }
}
// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

//Dictionary Way
var inputString = "1001";
var replacements = new Dictionary<char, char>()
{
    { '0', '*' }
};
inputString = replacements.Aggregate(inputString,
    (current, item) => current.Replace(item.Key, item.Value));
Console.WriteLine(inputString); // 1**1
//strategy Pattern
var replacementContext = new ReplacementContext(new ZeroReplacementStrategy());
var outputString = replacementContext.Replace(inputString);
Console.WriteLine(outputString); //1**1
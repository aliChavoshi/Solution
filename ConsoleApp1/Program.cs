// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
using ConsoleApp1.Dictionary;
using ConsoleApp1.Strategy;

//Dictionary Way
var dictionary = new ReplaceCharacter().Replace("1001");
Console.WriteLine(dictionary);
//strategy Pattern
var replacementContext = new ReplacementContext(new ZeroReplacementStrategy());
var outputString = replacementContext.Replace("1010");
Console.WriteLine(outputString); 
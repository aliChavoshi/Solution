﻿namespace ConsoleApp1;

public class ReplacementContext
{
    private readonly IReplacementStrategy _strategy;

    public ReplacementContext(IReplacementStrategy strategy)
    {
        _strategy = strategy;
    }

    public string Replace(string input)
    {
        return _strategy.Replace(input);
    }
}
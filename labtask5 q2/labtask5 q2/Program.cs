using System;

class Program
{
    static void Main(string[] args)
    {
        string[] s = { "hello ", "and ", "welcome ", "to ", "this ", "demo! " };
        string mergedString = Merger(s);

        Console.WriteLine(mergedString);
    }

    static string Merger(string[] inputArray)
    {
        return string.Concat(inputArray);
    }
}

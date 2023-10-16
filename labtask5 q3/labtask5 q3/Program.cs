using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string inputString = "This is a sample string with words of various lengths.";

        string[] result = ExtractWordsWithCriteria(inputString);

        Console.WriteLine("Words with 4-5 characters and containing vowels:");
        foreach (string word in result)
        {
            Console.WriteLine(word);
        }
    }

    static string[] ExtractWordsWithCriteria(string input)
    {
        // Use regular expressions to split the input into words
        string[] words = Regex.Split(input, @"\W+");

        // Use LINQ to filter words based on length and vowel presence
        string[] filteredWords = words
            .Where(word => word.Length >= 4 && word.Length <= 5 && ContainsVowels(word))
            .ToArray();

        return filteredWords;
    }

    static bool ContainsVowels(string word)
    {
        string vowels = "AEIOUaeiou";
        return word.Any(c => vowels.Contains(c));
    }
}

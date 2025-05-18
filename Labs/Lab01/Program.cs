using System.Text;
using System.Text.RegularExpressions;

namespace Lab01;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("=== Task 1 ===");
        Console.WriteLine(RemoveMiddle("example"));
        Console.WriteLine(RemoveMiddle("testing"));
        
        Console.WriteLine("\n=== Task 2 ===");
        var capacity = ProcessStrings(out var result, "He110", "Tes7ing", "123");
        Console.WriteLine($"Result: {result}, Capacity: {capacity}");
        
        Console.WriteLine("\n=== Task 3 ===");
        const string text = "Hi, this is email@example.com. Delete the word with the letter a.";
        Console.WriteLine(RemoveWordsContainingChar(text, 'a'));
    }
    
    private static string RemoveMiddle(string input)
    {
        var length = input.Length;
        if (length == 0) return input;

        if (length % 2 == 0)
        {
            var mid1 = length / 2 - 1;
            return input.Remove(mid1, 2);
        }
        else
        {
            var mid = length / 2;
            return input.Remove(mid, 1);
        }
    }
    
    private static int ProcessStrings(out string result, params string[] strings)
    {
        var builder = new StringBuilder();
        foreach (var str in strings)
        {
            var temp = new StringBuilder();
            foreach (var c in str)
            {
                temp.Append(char.IsDigit(c) ? '*' : c);
            }
            if (builder.Length > 0)
                builder.Append(';');
            builder.Append(temp);
        }
        builder.Capacity = builder.Length;
        result = builder.ToString();
        
        return builder.Capacity;
    }
    
    private static string RemoveWordsContainingChar(string input, char ch)
    {
        var pattern = $@"\b\w*{char.ToLower(ch)}\w*|\w*{char.ToUpper(ch)}\w*\b";
        return Regex.Replace(input, pattern, "", RegexOptions.IgnoreCase).Replace("  ", " ").Trim();
    }
}
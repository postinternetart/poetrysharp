using System;
using System.Linq;

class Search
{
    static void Main()
    {
        var years = new[]
        {
            "summer",
            "letters",
            "laughter",
            "departure"
        };

        var found =
            from item in years
            where item.Contains("you")
            select item;

        Console.WriteLine(
            found.Any()
                ? "found"
                : "no matching records"
        );
    }
}
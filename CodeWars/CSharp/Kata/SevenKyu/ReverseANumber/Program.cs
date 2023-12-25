using System;
using System.Linq;

public class Kata
{
    public static void Main()
    {
        var kata = new Kata();

        // Test 1
        int result1 = kata.ReverseNumber(123);
        Console.WriteLine($"Test 1: {result1}");

        // Test 2
        int result2 = kata.ReverseNumber(-123);
        Console.WriteLine($"Test 2: {result2}");

        // Test 3
        int result3 = kata.ReverseNumber(0);
        Console.WriteLine($"Test 3: {result3}");
    }

    public int ReverseNumber(int n)
    {
        string reversedStringFinal;

        if (n < 0)
        {
            n*=-1;
            var reversedStringNumber = new string(n.ToString().Reverse().ToArray());
            reversedStringFinal = "-" + reversedStringNumber;
        }
        else
        {
            reversedStringFinal = new string(n.ToString().Reverse().ToArray());
        }

        return int.Parse(reversedStringFinal);
    }
}

using System;

public static class Kata
{
    public static void Main()
    {
        PrintResult("Test1_EmptyString_ReturnsZero", GetVowelCount("") == 0);
        PrintResult("Test2_NoVowels_ReturnsZero", GetVowelCount("xyz") == 0);
        PrintResult("Test3_SingleVowel_ReturnsOne", GetVowelCount("a") == 1);
        PrintResult("Test4_MultipleVowels_ReturnsCorrectCount", GetVowelCount("hello world") == 3);
        PrintResult("Test5_CapitalVowels_ReturnsCorrectCount", GetVowelCount("AEIOU") == 5);
        PrintResult("Test6_MixedCaseVowels_ReturnsCorrectCount", GetVowelCount("AbCdE") == 2);
        PrintResult("Test7_VowelsWithConsonants_ReturnsCorrectCount", GetVowelCount("hello123") == 2);
        PrintResult("Test8_WhitespaceAndVowels_ReturnsCorrectCount", GetVowelCount("  a  e i o u  ") == 5);
        PrintResult("Test9_Punctuation_ReturnsZero", GetVowelCount("!,.?") == 0);
        PrintResult("Test10_NullString_ReturnsZero", GetVowelCount(null) == 0);
    }

    private static void PrintResult(string testName, bool result)
    {
        Console.WriteLine($"{testName}: {(result ? "Passed" : "Failed")}");
    }
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        if (str.Length <= 0)
        {
            return 0;
        }

        if (str == null)
        {
            return 0;
        }

        // Your code here
        foreach (char ch in str.ToLower()) // Convert to lowercase to handle both uppercase and lowercase vowels
        {
            if ("aeiou".Contains(ch)) // Check if the character is a vowel
            {
                vowelCount++;
            }
        }

        return vowelCount;
    }

    public static int GetVowelCountBestSolution(string str)
    {
        return str.Count(i => "aeiou".Contains(i));
    }

}
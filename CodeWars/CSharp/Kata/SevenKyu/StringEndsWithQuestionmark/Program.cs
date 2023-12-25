using System;
public class Kata
{
    public static void Main()
    {
               // Test 1
        Console.WriteLine($"Test 1: {Solution("abcde", "cde")}");  // Should print True

        // Test 2
        Console.WriteLine($"Test 2: {Solution("abcde", "abc")}");  // Should print False

        // Test 3
        Console.WriteLine($"Test 3: {Solution("abcde", "de")}");   // Should print True

        // Test 4
        Console.WriteLine($"Test 4: {Solution("abcde", "abcde")}"); // Should print True

        // Test 5
        Console.WriteLine($"Test 5: {Solution("abc", "")}");       // Should print True

    }
    public static bool Solution(string str, string ending)
    {
        //Can be solved with using C#'s return str.EndsWith(ending);, but that is no fun :) 
        
        if(str == null || ending == null || str.Length < ending.Length){
            return false;
        }

        var pointerA = str.Length-1;
        var pointerB = ending.Length-1;

        for (int i = 0; i < ending.Length; i++)
        {
            if(pointerA < 0 || pointerB <0){
                return false;
            }

            if(str[pointerA] == ending[pointerB]){
                pointerA--;
                pointerB--;
                continue;
            } else {
                return false;
            }

        }

        return true;
    }
}
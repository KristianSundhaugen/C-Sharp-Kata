using System;
public class Kata
{
    public static void Main()
    {
        // Test 1
        Console.WriteLine($"Test 1: {DigitalRoot(942)}");  // Should print 6

        // Test 2
        Console.WriteLine($"Test 2: {DigitalRoot(16)}");   // Should print 7

        // Test 3
        Console.WriteLine($"Test 3: {DigitalRoot(456)}");  // Should print 6

        // Test 4
        Console.WriteLine($"Test 4: {DigitalRoot(0)}");    // Should print 0

        // Test 5
        Console.WriteLine($"Test 5: {DigitalRoot(999999)}");  // Should print 9

        // Add more tests as needed
    }

    public static int DigitalRoot(long n)
    {
        // Convert long to string
        string nAsString = n.ToString();

        // Convert string to char array
        char[] charArray = nAsString.ToCharArray();

        // Convert char array to int array
        int[] intArray = Array.ConvertAll(charArray, c => (int)Char.GetNumericValue(c));

        if (intArray.Length == 1)
        {
            return intArray[0];
        }

        int sum = 0;

        foreach (int value in intArray)
        {
            sum += value;
        }

        if (sum > 9)
        {
            return DigitalRoot(sum);
        }

        return sum;
    }
}
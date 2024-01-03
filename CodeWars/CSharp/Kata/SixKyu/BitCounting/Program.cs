using System;

public class Kata
{
    public static void Main()
    {
        Console.WriteLine(CountBits(1234));
    }

    public static int CountBits(int n)
    {
        if (n < 0)
        {
            return -1;
        }

        string binary = IntToBinary(n);

        int amountOfBits = BinaryCounter(binary);

        return amountOfBits;
    }

    private static string IntToBinary(int n)
    {
        return Convert.ToString(n, 2);
    }

    private static int BinaryCounter(string binaryString)
    {
        return binaryString.Count(c => c == '1');
    }
}
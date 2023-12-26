using System;

public static class Kata
{
    public static void Main()
    {
        Console.WriteLine(DescendingOrder(42145));       // Output: 54421
        Console.WriteLine(DescendingOrder(145263));      // Output: 654321
        Console.WriteLine(DescendingOrder(123456789));  // Output: 987654321
    }


    public static int DescendingOrder(int num)
    {
        //Way of using types helping methods 
        //int result = int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
        int result = 0;
        int[] digits = ExctractDigits(num);
        // Implement a Bubble sort algorithm
        for (int i = 0; i < digits.Length - 1; i++)
        {
            for (int j = i + 1; j < digits.Length; j++)
            {
                if (digits[i] < digits[j])
                {
                    Swap(ref digits[i], ref digits[j]);
                }
            }
        }

        //Loop through and add the digits to a final result after sort
        for (int i = 0; i < digits.Length; i++)
        {
            result = result * 10 + digits[i];
        }

        return result;
    }

    static int[] ExctractDigits(int num)
    {
        int count = 0;
        int tmp = num;
        //Loop through and find amount of digits in a number
        while (tmp > 0)
        {
            tmp /= 10;
            count++;
        }

        //Initilize array with amount of digits counted
        int[] digits = new int[count];

        //Use modulo to add each number to array. %10 makes last number become rest
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = num % 10;
            num /= 10;
        }

        return digits;
    }

    //Use refrence to switch two numbers
    static void Swap(ref int a, ref int b)
    {
        int tmp = a;
        a = b;
        b = tmp;
    }
}
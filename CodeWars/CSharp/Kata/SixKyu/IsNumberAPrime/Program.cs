public static class Kata
{

    public static void Main()
    {
        Console.WriteLine($"IsPrime(-5): {IsPrime(-5)}");            // Should print: IsPrime(-5): False
        Console.WriteLine($"IsPrime(0): {IsPrime(0)}");              // Should print: IsPrime(0): False
        Console.WriteLine($"IsPrime(1): {IsPrime(1)}");              // Should print: IsPrime(1): False
        Console.WriteLine($"IsPrime(2): {IsPrime(2)}");              // Should print: IsPrime(2): True
        Console.WriteLine($"IsPrime(3): {IsPrime(3)}");              // Should print: IsPrime(3): True
        Console.WriteLine($"IsPrime(10): {IsPrime(10)}");            // Should print: IsPrime(10): False
        Console.WriteLine($"IsPrime(17): {IsPrime(17)}");            // Should print: IsPrime(17): True
        Console.WriteLine($"IsPrime(25): {IsPrime(25)}");            // Should print: IsPrime(25): False
        Console.WriteLine($"IsPrime(997): {IsPrime(997)}");          // Should print: IsPrime(997): True
        Console.WriteLine($"IsPrime(1000): {IsPrime(1000)}");        // Should print: IsPrime(1000): False

    }
    public static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        if (n == 2)
        {
            return true;
        }

        if (n % 2 == 0)
        {
            return false;
        }

        //Iterates only up to the square root of n
        //Becasue if n is not a prime, it must have a factor 
        //smaller than or equal to its square root
        int sqrt = (int)Math.Sqrt(n);

        for (int i = 3; i <= sqrt; i += 2)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
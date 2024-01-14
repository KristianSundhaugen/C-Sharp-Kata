public class Kata
{
    public static void Main()
    {
        Console.WriteLine(BouncingBall(3,0.66,1.5));
        Console.WriteLine(BouncingBall(3,1,1.5));
    }

    public static int BouncingBall(double h, double bounce, double window)
    {
        if (h <= 0)
        {
            return -1;
        }

        if (bounce <= 0 || bounce >= 1)
        {
            return -1;
        }

        if (window >= h)
        {
            return -1;
        }

        double bounceHeight = h;
        int seenBounces = 0;

        do
        {
            bounceHeight *= bounce;

            //Ball is falling
            seenBounces++;

            if (bounceHeight > window)
            {
                //Ball is passing window on the way up
                seenBounces++;
            }

        } while (bounceHeight > window);


        return seenBounces;
    }
}
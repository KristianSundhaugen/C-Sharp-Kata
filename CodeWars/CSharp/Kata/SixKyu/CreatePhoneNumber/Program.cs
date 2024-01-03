using System.Text;

public class Kata
{
    public static void Main()
    {
        Console.WriteLine(CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 })); // => returns "(123) 456-7890"
        Console.WriteLine(CreatePhoneNumberBestScoredSubmission(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 })); // => returns "(123) 456-7890"
    }

    //This is the subission that got highest score at CodeWars
    public static string CreatePhoneNumberBestScoredSubmission(int[] numbers){
        return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
    }

    //This is my solution
    public static string CreatePhoneNumber(int[] numbers)
    {
        if (numbers.Length != 10)
        {
            return "";
        }

        StringBuilder phoneNumber = new StringBuilder();

        for (int i = 0; i < numbers.Length; i++)
        {
            switch(i){
                case 0:
                    phoneNumber.Append("(");
                    phoneNumber.Append(numbers[i]);
                    break;
                case 3:
                    phoneNumber.Append(") ");
                    phoneNumber.Append(numbers[i]);
                    break;
                case 6:
                    phoneNumber.Append("-");
                    phoneNumber.Append(numbers[i]);
                    break;
                default:
                    phoneNumber.Append(numbers[i]);
                    break;
            }
        }
        return phoneNumber.ToString();
    }
}
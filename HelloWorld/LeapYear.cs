namespace HelloWorld;

public class LeapYear
{
    public static void Main(String[] args)
    {
        int intTemp = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(IsLeapYear(intTemp));
    }


    public static bool IsLeapYear(int year)
    {
        var output = false;

        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    output = true;
                    Console.WriteLine("yay");
                }
                else
                {
                    output = false;
                    Console.WriteLine("nay");
                }
            }
            else
            {
                output = true;
                Console.WriteLine("yay");
            }
        }
        else
        {
            output = false;
            Console.WriteLine("nay");
        }
        return output;

    }

    public static bool IsLeapYear2(int year)
    {
        if (DateTime.IsLeapYear(year))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
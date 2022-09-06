namespace HelloWorld;

public class LeapYear
{
    public static void Main(String[] args)
    {
        try
        {
            Console.Write("Enter a year: ");
            int intTemp = Convert.ToInt32(Console.ReadLine());
            IsLeapYear(intTemp);

        }
        catch (System.FormatException)
        {
            Console.WriteLine("Only integers please!");
        }


    }


    public static bool IsLeapYear(int year)
    {
        try
        {
            if (year < 1582)
            {
                throw new Exception();
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("Only works after year 1582");
            return false;
        }


        var output = false;
        string yay = "yay";
        string nay = "nay";

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
        if (output)
        {
            Console.WriteLine(yay);
            return true;
        }
        else
        {
            Console.WriteLine(nay);
            return false;
        }
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
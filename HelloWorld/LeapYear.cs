﻿namespace HelloWorld;

public class LeapYear
{
    public bool IsLeapYear(int year)
    {
        var output = false;

        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    output = true;
                }
                else
                {
                    output = false;
                }
            }
            else
            {
                output = true;
            }
        }
        else
        {
            output = false;
        }
        return output;

    }
}
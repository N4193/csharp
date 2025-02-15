using System;
public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool _IsLeapYear = false; //init the return variable
        
        if ((((year % 4) == 0 ) && ((year % 400) == 0) && ((year % 100) == 0)) || (((year % 100) != 0) && ((year % 4) == 0)))
        {       
            //Console.WriteLine($"{year} is divisible by 4 & 400 & 100 !");
            //Console.WriteLine($"{year} is leap year !");
            _IsLeapYear = true;
        }
        return _IsLeapYear;
    }
}
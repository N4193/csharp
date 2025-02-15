using System;
public static class Leap
{
    public static bool IsLeapYear(int year) 
    {
        bool _IsLeapYear = false;
        if ((year % 4) == 0 ) 
        {
            _IsLeapYear = true;
            if (((year % 100) == 0) && ((year % 400) != 0 ))
            {
                _IsLeapYear = false;
            }
        } 
        return _IsLeapYear;
    } 
}
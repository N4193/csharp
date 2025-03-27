using System;
using System.Runtime.InteropServices;

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime();
    
    public static DateTime Schedule(string appointmentDateDescription, Location location) => TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse(appointmentDateDescription), TimeZoneString(location));    //Convert schedule to UTC from other TimeZone
    
    public static TimeZoneInfo TimeZoneString(Location location)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))//if windows
        {
            switch(location)
            {
                case Location.NewYork : return TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                case Location.London :  return TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
                case Location.Paris :   return TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
            }
        }
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) || RuntimeInformation.IsOSPlatform(OSPlatform.OSX) )//if linux or OSX
        {
            switch(location)
            {
                case Location.NewYork : return TimeZoneInfo.FindSystemTimeZoneById("America/New_York");
                case Location.London :  return TimeZoneInfo.FindSystemTimeZoneById("Europe/London");
                case Location.Paris :   return TimeZoneInfo.FindSystemTimeZoneById("Europe/Paris");
            };
        }        
        return TimeZoneInfo.FindSystemTimeZoneById("Europe/Paris");
    }
    
    


    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
    {
        throw new NotImplementedException("Please implement the (static) Appointment.GetAlertTime() method");
    }

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        throw new NotImplementedException("Please implement the (static) Appointment.HasDaylightSavingChanged() method");
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        throw new NotImplementedException("Please implement the (static) Appointment.NormalizeDateTime() method");
    }
}

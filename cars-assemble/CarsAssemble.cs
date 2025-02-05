using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (1 <= speed && speed <= 4)
       {
            return 1.0;
       }
       else if (5 <= speed && speed <= 8)
       {
            return 0.90;
       }
       else if (speed == 9)
       {
            return 0.80;
       }
       else if (speed == 10)
       {
            return 0.77;
       }
       else return 0;
    }
    
    public static double ProductionRatePerHour(int speed) => speed * 221 * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed)=>(int)ProductionRatePerHour(speed) / 60;
}

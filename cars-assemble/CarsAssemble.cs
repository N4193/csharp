using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
     return speed switch 
     {
         int when (1 <= speed && speed <= 4) => 1.0,
         int when (5 <= speed && speed <= 8) => 0.90,
         int when (speed == 9) => 0.80,
         int when (speed == 10) =>0.77,
          _ => 0
     };
    }
    
    public static double ProductionRatePerHour(int speed) => speed * 221 * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed) / 60;
}

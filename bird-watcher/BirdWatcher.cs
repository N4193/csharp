using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()=> [0, 2, 5, 3, 7, 8, 4];
    
    public int Today() => birdsPerDay[birdsPerDay.Length-1];
    
    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length-1] =  birdsPerDay[birdsPerDay.Length-1]+1;
    }
    public bool HasDayWithoutBirds()
    {
        for(int i = 0; i < 7; i++)
        {
            if(birdsPerDay[i] == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        throw new NotImplementedException("Please implement the BirdCount.CountForFirstDays() method");
    }

    public int BusyDays()
    {
        throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");
    }
}

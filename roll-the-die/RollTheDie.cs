using System;
public class Player
{
    public int RollDie()
    {
        Random randomNum = new Random();
        return randomNum.Next(1, 18 + 1);
    }

    public double GenerateSpellStrength()
    {
        Random randomNum = new Random();
        return randomNum.NextDouble()*100;
    }
}

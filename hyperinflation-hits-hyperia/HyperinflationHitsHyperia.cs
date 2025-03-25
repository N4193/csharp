public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        try
        {
            checked
            {
                return $"{@base * multiplier}";
            }
        }
        catch (OverflowException e)
        {
            return "*** Too Big ***";
        }
    }

    public static string DisplayGDP(float @base, float multiplier)
    {
       if(float.IsInfinity(@base * multiplier))
       {
           return "*** Too Big ***";
       }
        return (@base * multiplier).ToString();
    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        throw new NotImplementedException($"Please implement the (static) CentralBank.DisplayChiefEconomistSalary() method");
    }
}

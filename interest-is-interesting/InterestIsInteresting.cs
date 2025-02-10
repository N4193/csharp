using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
    
        while (balance < 0)
        {
            return 3.213f;
        }
        while (0 > balance  || balance < 1000)
        {
            return 0.5f;
        }
        while (1000 > balance || balance < 5000)
        {
            return 1.621f;
        }         
        return 2.475f;
    }

    public static decimal Interest(decimal balance)
    {
        throw new NotImplementedException("Please implement the (static) SavingsAccount.Interest() method");
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        throw new NotImplementedException("Please implement the (static) SavingsAccount.AnnualBalanceUpdate() method");
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        throw new NotImplementedException("Please implement the (static) SavingsAccount.YearsBeforeDesiredBalance() method");
    }
}

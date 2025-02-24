using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        while (balance < 0){ return 3.213f; }
        while (0 > balance  || balance < 1000){return 0.5f;}
        while (1000 > balance || balance < 5000){return 1.621f;}         
        return 2.475f;
    }
    public static decimal Interest(decimal balance) => (balance * (decimal)InterestRate(balance))/100;
    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);
    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int _YearsBeforeDesiredBalance = 0;
        while ( balance < targetBalance)
        {
            _YearsBeforeDesiredBalance ++ ;
            balance = balance + Interest(balance);
        }
        return _YearsBeforeDesiredBalance;
    }
}
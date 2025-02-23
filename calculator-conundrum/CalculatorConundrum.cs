using System;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
       int resultCalculate = 0;
        try
        {
            resultCalculate = operation switch
            {
                "+" =>  operand1 + operand2,
                "/" =>  operand1 == 0 || operand2 == 0? 0  : operand1 / operand2,
                "*" =>  operand1 * operand2,
                _ => throw new ArgumentException()
            };
        }
        catch (Exception)
        {
            if (operation == null)throw new ArgumentNullException(nameof(operation));
            if (operation.Length > 1){throw new ArgumentOutOfRangeException("illegal operator");}
            if (operation.Length == 0){throw new ArgumentException("no operator");}
        }
        return resultCalculate == 0? "Division by zero is not allowed." : $"{operand1} {operation} {operand2} = {resultCalculate}";
    }
}
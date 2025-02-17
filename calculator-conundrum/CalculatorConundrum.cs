using System;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        int resultCalculate = 0;
        string _Calculate = "";    
        try
        {
            switch(operation)
            {
                default :
                    throw new ArgumentException();               
                case "+" :
                    resultCalculate = operand1 + operand2;
                    break;
                case "/" : 
                    try
                    {
                        resultCalculate = operand1 / operand2;
                        break;  
                    }
                    catch (Exception e)
                    {  
                        return "Division by zero is not allowed." ;    
                    }
                case "*" :    
                    resultCalculate = operand1 * operand2;
                    break;   
            }
        }
        catch (Exception e)
        {
            if (operation == null)throw new ArgumentNullException(nameof(operation));
            if (operation.Length > 1){throw new ArgumentOutOfRangeException("illegal operator");}
            if (operation.Length == 0){throw new ArgumentException("no operator");}
        }
         _Calculate = $"{operand1} {operation} {operand2} = {resultCalculate}";
        return _Calculate;
    }
}
using System;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        int resultCalculate = 0;
        string _Calculate = "";
        if (operation == null)throw new ArgumentNullException(nameof(operation));
        if (operation.Length > 1){throw new ArgumentOutOfRangeException("ArgumentOutOfRangeException");}
        switch(operation)
        {
            default :
                throw new ArgumentException("ArgumentException.", "number"); 
                break;
            case null :
                throw new ArgumentNullException("ArgumentNullException.", "number"); 
                break;                
            case "+" :
                resultCalculate = operand1 + operand2;
                _Calculate = $"{operand1} + {operand2} = {resultCalculate}";
                break;
            case "/" : 
                if (operand1 == 0 || operand2 == 0)
                {
                    _Calculate = "Division by zero is not allowed." ;
                    break;
                }
                resultCalculate = operand1 / operand2;
                _Calculate = $"{operand1} / {operand2} = {resultCalculate}";
                break;
            case "*" :    
                resultCalculate = operand1 * operand2;
                _Calculate = $"{operand1} * {operand2} = {resultCalculate}";
                break;
            case "-" :
                if(operand1 - operand2 < 0)
                {
                    throw new ArgumentOutOfRangeException("illgal opperation.", "number");
                    break;
                }           
                resultCalculate = operand1 - operand2;
                _Calculate = $"{operand1} - {operand2} = {resultCalculate}";    
                break;    
        }
        Console.WriteLine(_Calculate);
        return _Calculate;
    }
}

using System;
using System.Text;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        StringBuilder output = new StringBuilder(""); //revers output       
        for (int i = 0 ; i < input.Length; i++)
        {
            output.Append(input[(input.Length - 1) - i].ToString());
        }
        return output.ToString();

    }
} 
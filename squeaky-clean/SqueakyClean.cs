using System;

public static class Identifier
{
    
    public static string Clean(string identifier)
    {
        string Final = initialisation();
        Console.WriteLine(Final);
        Final = CleanSpace(identifier,Final);
        Console.WriteLine(Final);
        Final = CleanCTRL(identifier,Final);
        Console.WriteLine(Final);
        return Final;
    }
    public static string initialisation()
    {
        string Final = "";
        return Final;
    }

    public static string CleanSpace(string identifier,string Final)
    {
        string CleanSpace = Final;
        foreach (char element in identifier)
        {
            if (element.ToString() == " ")
            {
                CleanSpace = CleanSpace + "_";
            }
            else
            {
                CleanSpace = CleanSpace + element;
            }
        }
        return CleanSpace;
    }
        public static string CleanCTRL(string identifier,string Final)
    {
        string CleanCTRL = Final;
        foreach (char element in identifier)
        {
            if (element.ToString() == "\0")
            {
                CleanCTRL = CleanCTRL + "CTRL";
            }
            else
            {
                CleanCTRL = CleanCTRL + element;
            }
        }
        return CleanCTRL;
    }
}

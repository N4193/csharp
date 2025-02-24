using System;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder _Clean = new StringBuilder(identifier, 50);
        
        //task 1
        _Clean.Replace(' ', '_');
        //loop for search
        for (int i = _Clean.Length - 1; i >= 0; i--)
        {
            //task 2 if char is control
            if (char.IsControl(_Clean[i]))
            { 
                _Clean.Remove(i, 1);
                _Clean.Insert(i, "CTRL");
            }
            //task3 remove "-" + ToUpperInvariant()
            if (_Clean[i] == '-' )   
            { 
                 _Clean.Remove(i, 1);
                 _Clean[i] = char.ToUpperInvariant(_Clean[i]);
            }  
        }    
        //task4 if char is "special char" or "number"
        if (!(_Clean.ToString() == Regex.Replace(_Clean.ToString(), @"[^\p{L}]", "")))
        {
            string input = Regex.Replace(_Clean.ToString(), @"[^\p{L}_\s]", "");
            _Clean.Clear().Append(input);
        }
        //task5 if char is a greek lettrer (thank IA for this one lol I lock 4 hour but now understand the code )
        for (int i = _Clean.Length - 1; i >= 0; i--)
        {
            if (_Clean[i] >= 'α' && _Clean[i] <= 'ω') 
            {
                _Clean.Remove(i, 1);
            }
        }        
        return _Clean.ToString();
    }
}

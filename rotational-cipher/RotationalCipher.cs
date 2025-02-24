using System;
using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        shiftKey = shiftKey % 26; // Évite tout dépassement
        StringBuilder result = new StringBuilder();

        if (text == null) return ""; // Sécurise contre les valeurs nulles
        foreach (char c in text)
        {
            if (char.IsLetter(c)) // IF isLettrer
            {
                char baseChar = char.IsUpper(c) ? 'A' : 'a';
                int newIndex = (c - baseChar + shiftKey) % 26;
                if (newIndex < 0) newIndex += 26;  //if negativ 

                char newChar = (char)(baseChar + newIndex);
                result.Append(newChar);
            }
            else
            {
                result.Append(c); //IF !lettrer
            }
        }
        return result.ToString();
    }
}
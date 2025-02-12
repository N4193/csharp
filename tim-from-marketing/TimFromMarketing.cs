using System;
using System.Text;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        StringBuilder returnString = new StringBuilder();
        if (!(id == null))
        {
            returnString.Append($"[{id}] - ");
        }
        returnString.Append($"{name} - ");
        if (!(department == null))
        {
            returnString.Append($"{department.ToUpper()}");
        }else if (department == null)
        {
            returnString.Append($"OWNER");
        }
        return returnString.ToString();
    }
}
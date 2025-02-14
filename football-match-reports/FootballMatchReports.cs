using System;
using System.Reflection;
public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch (shirtNum)
        {
        case 1 : 
            return "goalie";
                break;
        case 2 : 
            return "left back";
            break;
        case 3 or 4 : 
            return "center back";
            break;
        case 5 : 
            return "right back";
            break;
        case 6 or 7 or 8 :
            return "midfielder";
            break;
        case 9 : 
            return "left wing";
            break;
        case 10 : 
            return "striker";
            break;
        case 11 : 
            return "right wing";
            break;
        default : 
            return "UNKNOWN";
            break;
        }     
    }
    
    public static string AnalyzeOffField(object report)
    {
    //---I build lil dirty tool to scan proprety & method() 
    object MyVarToInspect = report; //changer la variable report ici /!\   
    if (MyVarToInspect == null) Console.WriteLine("L'objet est null.");
        Console.WriteLine($"objet: {MyVarToInspect}");
        var type = MyVarToInspect.GetType();
        //boucle recherche de method
        foreach (var method in type.GetMethods())
        {
            Console.WriteLine($"Méthode : {method.Name}()");
        }
        //boucle Recherche de valeurs
        foreach (var prop in type.GetProperties())
        {
            if (prop.PropertyType == typeof(string))
            {
                var value = prop.GetValue(MyVarToInspect)?.ToString();
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine($"valeurs : {value}");
                }
            }
        }
    //---    
    switch (report)
        {  
        case int : return $"There are {report} supporters at the match.";
        case string announcement: return $"{announcement}";
        case Injury injury: return $"Oh no! {injury.GetDescription()} Medics are on the field.";
        case Incident incident: return incident.GetDescription();
            //pas beau ! 
        case Manager manager:
                if (manager.Club != null)
                {
                    return $"{manager.Name} ({manager.Club})";
                }
                return $"{manager.Name}";  
        default :
            return "";
            break;
        }
    }
}

using System;
using System.Reflection;
public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        return shirtNum switch
        {
            1=>"goalie",
            2=>"left back",
            3=>"center back",
            4=>"center back",
            5=>"right back",
            6=>"midfielder",
            7=>"midfielder",
            8=>"midfielder",
            9=>"left wing",
            10=>"striker",
            11=>"right wing",
            _=>"UNKNOWN"
        };
    }
    
    public static string AnalyzeOffField(object report)
    {
    /*---I build lil dirty tool to scan proprety & method() 
    //changer la variable report ici /!\

    object MyVarToInspect = report;    
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
    */ 
    return report switch
    {
        int                 => $"There are {report} supporters at the match.",
        string announcement => $"{announcement}",
        Injury injury       => $"Oh no! {injury.GetDescription()} Medics are on the field.",
        Incident incident   => incident.GetDescription(),
        Manager manager     => manager.Club != null ? $"{manager.Name} ({manager.Club})" : $"{manager.Name}",
        _ => "" 
    };
    }
}

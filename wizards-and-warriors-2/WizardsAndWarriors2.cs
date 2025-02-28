static class GameMaster
{
    public static string Describe(Character character ) => $"You're a level {character.Level} {character.Class} with {character.HitPoints} hit points.";
    
    public static string Describe(Destination destination)=> $"You've arrived at {destination.Name}, which has {destination.Inhabitants} inhabitants.";
    
    public static string Describe(TravelMethod travelMethod)
    {
       return  travelMethod.ToString() switch
       {
            "Walking" => "You're traveling to your destination by walking.",
            "Horseback" => "You're traveling to your destination on horseback.",
            _ => "Null"
       };
    }

    public static string Describe(Character character, Destination destination, TravelMethod travelMethod)
    {
        throw new NotImplementedException("Please implement the (static) GameMaster.Describe(Character, Destination, TravelMethod) method");
    }

    public static string Describe(Character character, Destination destination)
    {
        throw new NotImplementedException("Please implement the (static) GameMaster.Describe(Character, Destination) method");
    }
}

class Character
{
    public string ?Class { get; set; }
    public int ?Level { get; set; }
    public int ?HitPoints { get; set; }
}

class Destination
{
    public string ?Name { get; set; }
    public int ?Inhabitants { get; set; }
}

enum TravelMethod
{
    Walking,
    Horseback
}

public record FacialFeatures(string EyeColor, decimal PhiltrumWidth);
public record Identity(string Email,FacialFeatures FacialFeatures);

public class Authenticator
{
    private readonly Identity admin = new Identity("admin@exerc.ism", new FacialFeatures("green",0.9m));
    private readonly HashSet<Identity> allIdentity = new HashSet<Identity>();
     
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => (faceA.Equals(faceB));

    public bool IsAdmin(Identity identity) => (identity.Equals(admin));

    public bool Register(Identity identity) => allIdentity.Add(identity);    

    public bool IsRegistered(Identity identity) => allIdentity.Contains(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB) => (object.ReferenceEquals(identityB,identityA));
}
/*
BIG THANKS TO Coding Tutorials ♥
---> https://www.youtube.com/watch?v=JDLqwxYME6M 
*/
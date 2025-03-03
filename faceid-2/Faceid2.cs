public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    // TODO: implement equality and GetHashCode() methods

}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    // TODO: implement equality and GetHashCode() methods
}

public class Authenticator
{
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return (faceA.EyeColor.GetHashCode()==faceB.EyeColor.GetHashCode());
    }

    public bool IsAdmin(Identity identity) => (identity.Email == "admin@exerc.ism" &&
                identity.FacialFeatures.EyeColor.ToString() == "green" &&
                identity.FacialFeatures.PhiltrumWidth == 0.9m);

    public bool Register(Identity identity)
    {
        if(IsRegistered(identity))
        {
            return false;
        }
        return true;
    }

    public bool IsRegistered(Identity identity)
    {
        return true;
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return (identityA.GetHashCode()==identityB.GetHashCode());
    }
}

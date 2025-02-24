using System;

abstract class Character
{
    //propety
    public string _characterType = "";
    public bool _Vulnerable = false;
    public bool _PrepareSpell = false;
    //method
    protected Character(string characterType)
    {
        _characterType = characterType;
    }
    public abstract int DamagePoints(Character target);
    public virtual bool Vulnerable() => _Vulnerable;
}
class Wizard : Character
{
    public Wizard() : base("Wizard") 
    {
        base._Vulnerable = base._PrepareSpell ? false : true; 
    }
    public override string ToString() => $"Character is a {base._characterType}";
    public override int DamagePoints(Character target) => target._Vulnerable ? 3 : 12;
    public void PrepareSpell()
    {
        base._PrepareSpell = true;
        base._Vulnerable = false;
    }
}
class Warrior : Character
{
    public Warrior() : base("Warrior"){}
    public override string ToString() => $"Character is a {base._characterType}";
    public override int DamagePoints(Character target) => target._Vulnerable ? 10 : 6; 
}
using System;

class WeighingMachine
{
    //work on CLI 9/9test via "dotnet test" with framework net9.0 :D 
    public WeighingMachine(int precision) => Precision = precision;
    public int Precision {get; private set;}
    private double _weight;
    public double Weight
    {
        get => _weight;
        set
        {
            if (value < 0)throw new ArgumentOutOfRangeException("no negative !");
                _weight = value;                
        }
    }
    public string DisplayWeight 
    { 
        get=> $"{(_weight - TareAdjustment).ToString($"f{Precision}")} kg";
        set; 
    }
    public double TareAdjustment { get;  set; } = 5;
}

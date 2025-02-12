using System;

class RemoteControlCar
{
    // propriety
    private int speed;
    private int batteryDrain;
    private int batteries = 100;//actual car batteries percent
    private int metersDriven = 0;//actual meters the car has drive
    private bool _BatteryDrained = false;//true if the battries is over
    //get stats function()
    public int get_speed() => this.speed;
    public int get_batteryDrain() => this.batteryDrain;
    public int get_batteries() => this.batteries;
    public int get_maxdistance() => (100 / batteryDrain)*speed;
    //RemoteControlCar functions
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        if (get_batteryDrain() > get_batteries())
        {
            this._BatteryDrained = true;
            return this._BatteryDrained; 
        }
        while(get_batteries() >= 1)
        {
            Console.WriteLine($"baterie is:{get_batteries()} percent");
            this._BatteryDrained = false;
            return this._BatteryDrained;
        }
        Console.WriteLine("Low Battrie indicator");
        this._BatteryDrained = true;
        return this._BatteryDrained;        
    }
    
    public int DistanceDriven() => this.metersDriven;
    public void Drive()
    {
        if (!(BatteryDrained()))
        {
            Console.WriteLine("Drive !");
            this.metersDriven = DistanceDriven() + (get_speed());
            this.batteries = this.batteries - this.batteryDrain;
        }  
        else if(this._BatteryDrained == true)
        {
            Console.WriteLine($"can't drive ,battery is : {this.batteries} percent");   
        }
    }
    public static RemoteControlCar Nitro() => new RemoteControlCar(50,4); 
}

class RaceTrack
{ 
    int distanceRaceTrack = 0;
    public RaceTrack(int distance) => this.distanceRaceTrack = distance;
    public bool TryFinishTrack(RemoteControlCar car) => (car.get_maxdistance() >= this.distanceRaceTrack);
}

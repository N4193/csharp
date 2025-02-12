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
    public bool BatteryDrained()=>(get_batteries() - get_batteryDrain()) < 0;
    public int DistanceDriven() => this.metersDriven;
    public void Drive()
    {
        if (!(BatteryDrained()))
        {
            this.metersDriven = DistanceDriven() + (get_speed());
            this.batteries = this.batteries - this.batteryDrain;
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
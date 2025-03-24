public class RemoteControlCar
{
    private int batteryPercentage = 100;
    private int distanceDrivenInMeters = 0;
    private string[] sponsors = new string[0];
    private int latestSerialNum = 0;
    

    public void Drive()
    {
        if (batteryPercentage > 0)
        {
            batteryPercentage -= 10;
            distanceDrivenInMeters += 2;
        }
    }
    //task1
    public void SetSponsors(params string[] sponsors) => this.sponsors = sponsors ;
    public string DisplaySponsor(int sponsorNum) => sponsors[sponsorNum];
    //task2
    public bool GetTelemetryData(ref int serialNum, out int batteryPercentage, out int distanceDrivenInMeters)
    {
        batteryPercentage = this.batteryPercentage;
        distanceDrivenInMeters = this.distanceDrivenInMeters;
        if(latestSerialNum<serialNum)
        {
            latestSerialNum = serialNum;
            return true;     
        }
        serialNum = latestSerialNum;
        batteryPercentage = -1;
        distanceDrivenInMeters = -1;
        return false;  
    }
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }
}

public class TelemetryClient
{
    private RemoteControlCar car;
    private string usagePerMeter = "no data";
    
    public TelemetryClient(RemoteControlCar car)
    {
        this.car = car;
    }
    public string GetBatteryUsagePerMeter(int serialNum)
    {
        //task3
        int batteryPercentage,distanceDrivenInMeters = 0;
        car.GetTelemetryData(ref serialNum,out batteryPercentage,out distanceDrivenInMeters);
        if(distanceDrivenInMeters>0)
        {
            usagePerMeter = $"usage-per-meter={(100-batteryPercentage)/distanceDrivenInMeters}";
        }
        return usagePerMeter;
    }
}

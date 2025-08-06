class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int battery = 100;
    private int speed = 0;
    private int meter = 0;
	private int batteryDrain = 0;
    public RemoteControlCar()
    {
        
    }
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.batteryDrain = batteryDrain;
        this.speed = speed;
   }
    public bool BatteryDrained() => battery < batteryDrain;
    public int DistanceDriven() => meter;

    public void Drive()
    {
       if(BatteryDrained()){
           return;
       }
        meter += speed;
        battery -= batteryDrain;	
    }

     public static RemoteControlCar Nitro() =>new RemoteControlCar(50, 4);
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int distance = 0;   
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        var driven = 0;
       while(driven <= distance && !car.BatteryDrained()){
		   car.Drive();
		   driven = car.DistanceDriven();
	   }
         return car.DistanceDriven() >= distance; 
    }
}
public class Car
{
    private string Engine;
    private int Wheel;
    private string AirBug;

    public Car(CarBuilder builder)
    {
        Engine = builder.Engine;
        Wheel = builder.Wheel;
        AirBug = builder.AirBug;
    }
    public string GetEngine(){ 
        return Engine;
    }
    public int GetWheel(){ 
        return Wheel;
    }
    public string GetAirBug(){ 
        return AirBug;
    }
}
public class CarBuilder
{
    public string Engine;
    public int Wheel;
    public string AirBug;

public CarBuilder BuildEngine(string engine){
    Engine = engine;
    return this;
}
public  CarBuilder BuildWheel(int wheel){
    Wheel = wheel;
    return this;
}
public CarBuilder BuildAirBug(string airBug){
    AirBug = airBug;
    return this;
}
public Car Build(){
    return new Car(this);
}

}
# Builder design pattern
Just like you use getter and setter in one class
with builder you have two classes with the same properties `client` and `builder` class 

then you define setter methods in the builder class along with Build method that return instance of client class

**Client  class**
```
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

```
**Builder class**
``` 
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

 ```

In class which will use client class source code do like this

```
CarBuilder newCarBuilder = new CarBuilder();
newCarBuilder.BuildWheel(4).BuildEngine("v8").BuildAirBug("air what ever").Build();
Car maserati = new Car(newCarBuilder);
System.Console.WriteLine(newCarBuilder.GetWheel());

```
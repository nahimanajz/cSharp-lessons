// See https://aka.ms/new-console-template for more information
CarBuilder newCarBuilder = new CarBuilder();
newCarBuilder.BuildWheel(4).BuildEngine("v8").BuildAirBug("air what ever").Build();
Car maserati = new Car(newCarBuilder);
System.Console.WriteLine(newCarBuilder.GetWheel());
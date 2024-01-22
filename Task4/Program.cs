Car myCar = new Car("Toyota", "Camry", 2022);
Console.WriteLine($"Make: {myCar.Mark}");
Console.WriteLine($"Model: {myCar.Model}");
Console.WriteLine($"Year: {myCar.Year}");
Console.WriteLine($"Mileage: {myCar.Mileage} miles");
Console.WriteLine($"Fuel level: {myCar.Fuel} gallons");
myCar.Drive(100);
myCar.AddFuel(10);
Console.WriteLine($"\nAfter the trip and refueling:");
Console.WriteLine($"Mileage: {myCar.Mileage} miles");
Console.WriteLine($"Fuel level: {myCar.Fuel} gallons");


public class Car
{
    public string Mark;
    public string Model;
    public int Year;
    public double Mileage;
    public double Fuel;
    public Car() {}
    public Car(string _mark, string _model, int _year, double _mil)
    {
        Mark = _mark;
        Model = _model;
        Year = _year;
        Mileage = _mil;
        Mileage = 0;
    }
    public void Drive(double miles){
        if(Fuel < 100) System.Console.WriteLine("Benzin pr k");
        else System.Console.WriteLine("Benzin hast");
    }
    public void AddFuel(double gallons){
        Fuel = gallons;
        Fuel++;
    }
}
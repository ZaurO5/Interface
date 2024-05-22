public class Car : IVehicle
{
    public string Name { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(string name, string model, int year)
    {
        Name = name;
        Model = model;
        Year = year;
    }

    public void Start()
    {
        Console.WriteLine("Car started.");
    }

    public void Stop()
    {
        Console.WriteLine("Car stopped.");
    }

    public string GetDetails()
    {
        return $"Car: {Name} {Model} {Year}";
    }
}

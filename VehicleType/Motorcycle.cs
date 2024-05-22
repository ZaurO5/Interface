public class Motorcycle : IVehicle
{
    public string Name { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Motorcycle(string name, string model, int year)
    {
        Name = name;
        Model = model;
        Year = year;
    }
    public void Start()
    {
        Console.WriteLine("Motorcycle started.");
    }

    public void Stop()
    {
        Console.WriteLine("Motorcycle stopped.");
    }
    public string GetDetails()
    {
        return $"Motorcycle: {Name} {Model} {Year}";
    }
}

public class Bus : IVehicle
{
    public string Name { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Bus(string name, string model, int year)
    {
        Name = name;
        Model = model;
        Year = year;
    }
    public void Start()
    {
        Console.WriteLine("Bus started.");
    }

    public void Stop()
    {
        Console.WriteLine("Bus stopped.");
    }
    public string GetDetails()
    {
        return $"Bus: {Name} {Model} {Year}";
    }
}

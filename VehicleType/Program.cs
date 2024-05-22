public class Program
{
    public static void Main(string[] args)
    {
        IVehicle myCar = new Car("Hyundai", "Elantra", 2023);
        IVehicle myBus = new Bus("Mercedes", "Tourismo", 2020);
        IVehicle myMotorcycle = new Motorcycle("Harley-Davidson", "Cruiser", 2016);

        myCar.Start();
        Console.WriteLine(myCar.GetDetails());
        myCar.Stop();

        myBus.Start();
        Console.WriteLine(myBus.GetDetails());
        myBus.Stop();

        myMotorcycle.Start();
        Console.WriteLine(myMotorcycle.GetDetails());
        myMotorcycle.Stop();
    }
}


    public class Program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight(Color.Red);

            Console.WriteLine("Initial color: " + trafficLight.CurrentColor);

            trafficLight.ChangeNextColor();
            Console.WriteLine("Next color: " + trafficLight.CurrentColor);

            trafficLight.ChangeNextColor();
            Console.WriteLine("Next color: " + trafficLight.CurrentColor);

            trafficLight.ChangeNextColor();
            Console.WriteLine("Next color: " + trafficLight.CurrentColor);
        }
    }

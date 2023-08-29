public class Program
{
    public static void Main(string[] args)
    {
        IVehicle car = VehicleFactory.createVehicle("P");
        Console.WriteLine(car.takeClient());
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var simple = new simpleFactory();
        VehicleFactory filial = simple.getFilial("S");
        IVehicle carro = filial.createVehicle("P");
        Console.WriteLine(carro.takeClient());
    }
}

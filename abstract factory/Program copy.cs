public class Program
{
    public static void Main(string[] args)
    {
        var simple = new simpleFactory();
        VehicleFactory filial = simple.getFilial("S");
        IVehicleRich carro = filial.createVehicleRich();
        Console.WriteLine(carro.takeClient());
    }
}

public class VehicleFactory
{
    public static IVehicle createVehicle(string tipo)
    {
        switch (tipo)
        {
            case "L":
                return new RichCar();
            case "P":
                return new PoorCar();
            default:
                throw new Exception("carro não encontrado");
        }
    }
}
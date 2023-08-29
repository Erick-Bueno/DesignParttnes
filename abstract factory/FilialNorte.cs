public class FilialNorte : VehicleFactory
{
    public IVehicleRich createVehicleRich(){
        return new RichCarZn();
    }
    public IVehiclePoor createVehiclePoor(){
        return new PoorCarZn();
    }

}
public class FilialSul : VehicleFactory
{
    public IVehicleRich createVehicleRich(){
        return new RichCarZs();
    }
    public IVehiclePoor createVehiclePoor(){
        return new PoorCarZs();
    }

}

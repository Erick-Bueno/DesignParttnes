public class simpleFactory
{
    public VehicleFactory getFilial(string filial){
        switch(filial){
            case "S":
                return new FilialSul();
            case "N":
                return new FilialNorte();
            default:
                throw new Exception("filial não encontrada");
        }
    }
}
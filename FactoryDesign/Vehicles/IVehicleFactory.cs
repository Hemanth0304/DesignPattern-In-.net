namespace FactoryDesign.Vehicles
{
    public interface IVehicleFactory
    {
        IVehicle create(string type);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryDesign.Vehicles
{
    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle create(string type)
        {
            return type switch
            {
                "Diesel" => new DieselVehicle(),
                "Petrol" => new PetrolVehicle(),
                _ => new ElectricVehicle()

            };
        }
    }
}

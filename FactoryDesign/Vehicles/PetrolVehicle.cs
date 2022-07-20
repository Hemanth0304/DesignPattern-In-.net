using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryDesign.Vehicles
{
    public class PetrolVehicle : IVehicle
    {
        public Vehicle[] GetVehicles()
        {
            return new[] { new Vehicle { Name = "This is a Petrol Vehicle" } };
        }
    }
}

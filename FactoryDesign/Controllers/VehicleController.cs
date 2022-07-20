using FactoryDesign.Vehicles;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryDesign.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleFactory vehicleFactory;

        public VehicleController(IVehicleFactory vehicleFactory)
        {
            this.vehicleFactory = vehicleFactory;
        }

        //GET Method
        [HttpGet]
        public IEnumerable<Vehicle> Get(string type)
        {
            return vehicleFactory.create(type).GetVehicles();
        }
    }
}

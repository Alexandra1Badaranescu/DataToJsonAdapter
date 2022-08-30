
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using JsonDataPrinter;
using DatabaseReader;

namespace JsonDataPrinter
{
    public void DisplayVehicleInfo(string VehicleInfo)
        {
        var vehicles = JsonSerializer.Deserialize<IEnumerable<Vehicle>>(VehicleInfo);

        if (vehicles == null)
            return ;
        foreach(var i in vehicles)
        {
            Console.WriteLine($"ID:{i.vehicleId}\n");
            Console.WriteLine($"Model:{i.vehicleModel}\n");
            Console.WriteLine($"Year:{i.vehicleYear}\n");
            Console.WriteLine($"Cost:{i.vehicleCost}\n");
        }


        }
         

 }

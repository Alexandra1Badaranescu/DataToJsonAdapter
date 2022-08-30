using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using DatabaseReader;

namespace Json
{
    public class JsonAdapter
    {
        public void Display(string VehicleInfo)
    {
        var vehicles = JsonSerializer.Deserialize<IEnumerable<Vehicle>>(VehicleInfo);

        if (vehicles == null)
            return;
        foreach (var i in vehicles)
        {
            Console.WriteLine($"ID:{i.ID} \n");
            Console.WriteLine($"Model:{i.Model} \n");
            Console.WriteLine($"Year:{i.Year} \n");
            Console.WriteLine($"Cost:{i.Cost} \n");
        }
    }


    }

}

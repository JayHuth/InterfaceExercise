using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        string Model { get; set; }
        string Make { get; set; }
        string Year { get; set; }
        string NumberOfWheels { get; set; }

    }
}

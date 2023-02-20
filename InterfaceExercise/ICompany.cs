using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create 2 members that are specific to each every company
                * regardless of vehicle type.
                *
                *
                * Example: public string Logo { get; set; }
                */

namespace InterfaceExercise
{
    internal interface ICompany 
    {
        string Name { get; set; }
        string Logo { get; set; }
    }
}

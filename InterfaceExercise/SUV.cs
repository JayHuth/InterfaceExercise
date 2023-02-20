﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create 2 members that are specific to each class
               * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
               *
               * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
               * 
               */

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany  
    {
       public string CargoHoldSize { get; set; }
       public bool HasThirdRow { get; set; }
       public string Name { get; set; }
       public string Logo { get; set; }
       public string Model { get; set; }
       public string Make { get; set; }
       public string Year { get; set; }
       public string NumberOfWheels { get; set; }
    }
}

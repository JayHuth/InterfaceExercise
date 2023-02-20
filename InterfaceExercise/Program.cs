using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car car1 = new Car();
            car1.Make = "Ford";
            car1.Model = "Focus";
            car1.FourDoor = false;
            car1.Year = "2018";
            car1.Logo = "blue circle with the name";
            car1.TrunkSize = "small";
            car1.Name = "Batmobile";
            car1.NumberOfWheels = "4";

            Truck truck1 = new Truck();
            truck1.BedSize = "Large";
            truck1.HasSecondRow = false;
            truck1.Name = "BigRig";
            truck1.Logo = "silver bulls head with horns";
            truck1.Model = "Tacoma";
            truck1.Make = "Toyota";
            truck1.Year = "2025";
            truck1.NumberOfWheels = "4";

            SUV suv1 = new SUV();
            suv1.CargoHoldSize = "Large";
            suv1.HasThirdRow = true;
            suv1.Name = "lone ranger";
            suv1.Logo = "blue circle with the name in it";
            suv1.Model = "Expidition";
            suv1.Make = "ford";
            suv1.Year = "1998";
            suv1.NumberOfWheels = "4";

            List<IVehicle> vehicles = new List<IVehicle>();

            vehicles.Add(truck1);
            vehicles.Add(suv1);
            vehicles.Add(car1);

            foreach(IVehicle vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year} Make: {vehicle.Make} Model: {vehicle.Model}");
            }

    }
    }
}

using AssignFive.InterfaceFolder;
using AssignFive.Manager;
using AssignFive.TheGarage;
using AssignFive.TheVehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignFive.ConsoleUI
{
    internal class UI
    {

        public static void ListAllGarage(Garage<Vehicle> laraSoft)
        {
            string header = String.Format("{0,-12}{1,7}{2,12}{3,12}\n", "VEHICLE", "REGNUM", "WHEELS", "EXTRA");

            Console.WriteLine(header);
           
            // string[] interfaces = { "IAirplane", "IBoat", "IBus", "IMotorcycle", "ICar" }; 

            foreach (Vehicle item in laraSoft)
            {

                if (item is IAirplane)
                {
                    Console.WriteLine(item.ToString());
                }
                if (item is IBoat)
                {
                    Console.WriteLine(item.ToString());
                }
                if (item is IBus)
                {
                    Console.WriteLine(item.ToString());
                }
                if (item is IMotorcycle)
                {
                    Console.WriteLine(item.ToString());
                }
                if (item is ICar)
                {
                    Console.WriteLine(item.ToString());
                }

            }
        }
        internal static void ListingOfVehicles(Garage<Vehicle> laraSoft)
        {   
            //var leGarage = BulkGarage.TestGarage();
            int[] sumVehicles = GarageHandler.CountVehicles(laraSoft);
            Console.WriteLine($"\n *** Garage Status ***\n"
                            + $"\nAIRPLANES:\t {sumVehicles[0]}"
                            + $"\nBOATS:\t\t {sumVehicles[1]}"
                            + $"\nBUSES:\t\t {sumVehicles[2]}"
                            + $"\nMOTORCYCLES:\t {sumVehicles[3]}"
                            + $"\nCARS:\t\t {sumVehicles[4]}");
        }
    }
}

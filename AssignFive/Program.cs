using AssignFive.InterfaceFolder;
using AssignFive.Manager;
using AssignFive.TheGarage;
using AssignFive.TheVehicles;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AssignFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Garage<Vehicle> leGarage = Garage<Vehicle>.GetInstance();
            //var leGarage = Garage<Vehicle>.InitArray(0);
            //Garage<Vehicle> leGarage = new Garage<Vehicle>(10);
            //BulkGarage.TestGarage(leGarage);
            /*foreach (Vehicle item in theLeGarage)
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
            Console.WriteLine(theLeGarage);*/

            // BulkGarage.TestGarage(Garage<Vehicle>.laraSoft);
            //Garage<Vehicle> theGarage = Garage<Vehicle>.OwnArr(4);
            //Console.WriteLine(theGarage.ToString());
            //Console.BackgroundColor = ConsoleColor.DarkGray;
            //Console.Clear();
            Meny.MenyText();
        }
    }
}
using AssignFive.Manager;
using AssignFive.TheGarage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignFive.TheVehicles;
using System.Collections.Generic;
using AssignFive.ConsoleUI;
using AssignFive.InterfaceFolder;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace AssignFive.TheGarage
{
    public class GarageHandler
    {
        public static int[] CountVehicles(Garage<Vehicle> theLeGarage)
        {

            int[] result = new int[5];

            foreach (var item in theLeGarage)
            {
                if (item is IAirplane)
                {
                    result[0] += 1;
                }
                if (item is IBoat)
                {
                    result[1] += 1;
                }
                if (item is IBus)
                {
                    result[2] += 1;
                }
                if (item is IMotorcycle)
                {
                    result[3] += 1;
                }
                if (item is ICar)
                {
                    result[4] += 1;
                }
            }

            return result;
        }


        public static void AddVehicle(char input)
        {
            string   engines;

            if (input == '1')
            {
                dynamic[] vehicleArray = SameVehicleInputs();
                
                Console.Write("Antal Motorer: ");
                engines = Console.ReadLine()!;
                int enginesResult = CheckInt(engines);

                Airplane air = new(vehicleArray[0], vehicleArray[1], vehicleArray[2], enginesResult);
                Garage<Vehicle>.laraSoft.Park(air);
                UI.GreenText("\n *** Ett Flygplan har parkerat! ***\n");
                return;
            }

            if (input == '2')
            {
                dynamic[] vehicleArray = SameVehicleInputs();

                Console.Write("Hur många Fot: ");
                string feet = Console.ReadLine()!;
                int feetResult = CheckInt(feet);
                
                Boat boat = new(vehicleArray[0], vehicleArray[1], vehicleArray[2], feetResult);
                Garage<Vehicle>.laraSoft.Park(boat);
                UI.GreenText("\n *** En Båt har parkerat! ***\n");
                return;
            }

            if (input == '3')
            {
                dynamic[] vehicleArray = SameVehicleInputs();

                Console.Write("Diesel eller Bensin: ");
                string fuel = Console.ReadLine()!;
                string engineFuel = CheckString(fuel);

                Bus bus = new(vehicleArray[0], vehicleArray[1], vehicleArray[2], engineFuel);
                Garage<Vehicle>.laraSoft.Park(bus);
                UI.GreenText("\n *** En Buss har parkerat! ***\n");
                return;
            }

            if (input == '4')
            {
                dynamic[] vehicleArray = SameVehicleInputs();

                Console.Write("Hur många CC: ");
                string cyl = Console.ReadLine()!;
                int cylVolume = CheckInt(cyl);

                Motorcycle motorCycle = new(vehicleArray[0], vehicleArray[1], vehicleArray[2], cylVolume);
                Garage<Vehicle>.laraSoft.Park(motorCycle);
                UI.GreenText("\n *** En Motorcykel har parkerat! ***\n");
                return;
            }

            if (input == '5')
            {
                dynamic[] vehicleArray = SameVehicleInputs();

                Console.Write("Hur många Säten: ");
                string seats = Console.ReadLine()!;
                int numberOfSeats = CheckInt(seats);

                Car car = new(vehicleArray[0], vehicleArray[1], vehicleArray[2], numberOfSeats);
                Garage<Vehicle>.laraSoft.Park(car);
                UI.GreenText("\n *** En Bil har parkerat! ***\n");
                return;
            }
            else
            {
                Console.WriteLine("\nInget objekt skapades");
            }
      
        }

        public static void RemoveVehicle(Garage<Vehicle>laraSoft)
        {
            string value = RegNumberInput();
            Garage<Vehicle>.laraSoft.Unpark(value);
            Console.WriteLine($"\n *** Fordon: {value} har lämnat Garaget! ***\n");
        }

       

        public static int CheckInt(string input)
        {
            int resultInt;
            while (!int.TryParse(input, out resultInt))
            {
                Console.WriteLine("Har du skrivit in en siffra?\n");
                Console.Write("Prova med en siffra: ");
                input = Console.ReadLine()!;
            }
          
            return resultInt;
        }

        public static string CheckString(string input)
        {
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Har du skrivit in något?\n");
                Console.Write("Prova igen: ");
                input = Console.ReadLine()!;
            }
            string resultString = input;
            return resultString;
        }

        public static dynamic[] SameVehicleInputs()
        {
            string regnr, color, numberInput;

            Console.Write("\nVilket Regnr: ");
            regnr = Console.ReadLine()!;
            regnr = CheckString(regnr);
            regnr.ToUpper();

            Console.Write("Hur många Hjul: ");
            numberInput = Console.ReadLine()!;
            int intToStringResult = CheckInt(numberInput);
          
            Console.Write("Vilken Färg: ");
            color = Console.ReadLine()!;
            color = CheckString(color);

            return new dynamic[] { regnr, intToStringResult, color };
        }

        public static string RegNumberInput()
        {
            Console.Write("Vilket Regnummer: ");
            string regnr = Console.ReadLine()!;
            regnr = CheckString(regnr);
           
            return regnr.ToUpper();
        }

        public static Garage<Vehicle> InitOwnGarageSize()
        {
            Console.Write("\nHur många Fordon ska få plats: ");
            string arraySize = Console.ReadLine()!;
            int numberOfIndexes = CheckInt(arraySize);
            Garage<Vehicle> theGarage = Garage<Vehicle>.OwnArr(numberOfIndexes);
            UI.GreenText($"\n *** Ett Garage med {numberOfIndexes} platser skapades! ***\n");   
            return theGarage;
        }
        public static void SearchVehicleArray()
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            Console.Write("\nSkriv komma eller punkt emellan era sökkriterier: ");
            string searchString =Console.ReadLine()!;
            searchString = CheckString(searchString);
            string[] searchResult = searchString.Split((delimiterChars));
            string test = "Violet";

            var vehicles = Garage<Vehicle>.theGarage;
          
        }
        /*public static List<dynamic> Search(Garage<Vehicle>vehicles, string test)
        {
            List<dynamic> list = new List<dynamic>();

            for (int i = 0; i < vehicles.Count; i++)
            {
                if (vehicles[i] != null && vehicles[i].Equals(test))
                {
                    list.Add(vehicles[i]);
                    Console.WriteLine(list);
                    return list;
                }
            }
            return list;
        }
*/
       
    }
}

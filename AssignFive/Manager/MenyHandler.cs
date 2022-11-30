using AssignFive.ConsoleUI;
using AssignFive.InterfaceFolder;
using AssignFive.ReadWriteFiles;
using AssignFive.TheGarage;
using AssignFive.TheVehicles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AssignFive.Manager
{
    public class MenyHandler
    {   
        
        public static void CheckGarage()
        {
            string meny =
                  "---------------------------\n"
                + "     Garageöversikten      \n"
                + "---------------------------\n"
                + "1: Kolla in Garaget\n"
                + "0: Tillbaka\n";

            while (true)
            { 
                Console.WriteLine(meny);

            char input = ' ';
            try
            {
                Console.Write("Skriv ert val: ");
                input = Console.ReadLine()![0]; 
            }
            catch (IndexOutOfRangeException) 
            {
                Console.Clear();
            }
            switch (input)
            {
                    case '1':
                        UI.ListAllGarage(Garage<Vehicle>.laraSoft);
                        break;
                    case '0':
                        Meny.MenyText();
                        break;
                    default:
                        Console.WriteLine("\n   *** Ni behöver skriva in ett nummer från Menyn! ***\n");
                        break;
            }
        }
    }


        public static void ListVehicles()
        {
            string meny =
                  "---------------------------\n"
                + "       Fordonslistan       \n"
                + "---------------------------\n"
                + "1: Räkna fordonen\n"
                + "0: Tillbaka\n";

            while (true)
            {
                Console.WriteLine(meny);

                char input = ' ';
                try
                {
                    Console.Write("Skriv ert val: ");
                    input = Console.ReadLine()![0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    //Console.WriteLine("Du behöver skriva in ett nummer!");
                }
                switch (input)
                {
                    case '1':
                        UI.ListingOfVehicles(Garage<Vehicle>.laraSoft);
                        break;
                    case '0':
                        Meny.MenyText();
                        break;
                    default:
                        Console.WriteLine("\n   *** Ni behöver skriva in ett nummer från Menyn! ***\n");
                        break;
                }
            }
        }
        public static void AlterGarage()
        {
            string meny =
                  "---------------------------\n"
                + "      Garageändringar      \n"
                + "---------------------------\n"
                + "1: Lägg till Fordon\n"
                + "2: Ta bort Fordon\n"
                + "0: Tillbaka\n";

            while (true)
            {
                Console.WriteLine(meny);

                char input = ' ';
                try
                {
                    Console.Write("Skriv ert val: ");
                    input = Console.ReadLine()![0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                }
                switch (input)
                {
                    case '1':
                        GettingVehicleInputs();
                        break;
                    case '2':
                        GettingRegNumberInputs();
                        break;
                    case '0':
                        Meny.MenyText();
                        break;
                    default:
                        Console.WriteLine("\n   *** Ni behöver skriva in ett nummer från Menyn! ***\n");
                        break;
                }            
            }
        }

        public static void GettingVehicleInputs()
        {
            //var leGarage = BulkGarage.TestGarage();
            string meny =
                 "---------------------------\n"
               + "      Välj fordonstyp      \n"
               + "---------------------------\n"
               + "1: Ett Flygplan\n"
               + "2: En Båt\n"
               + "3: En Buss\n"
               + "4: En Motorcykel\n"
               + "5: En Bil\n"
               + "0: Avsluta\n";

            while (true)
            {
                Console.WriteLine(meny);
             
                char nextinput = ' ';
                try
                {
                    Console.Write("Skriv ert val: ");
                    nextinput = Console.ReadLine()![0];      
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                }
                switch (nextinput)
                {
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                        GarageHandler.AddVehicle(nextinput);
                        break;
                    case '0':
                        AlterGarage();
                        break;
                    default:
                        Console.WriteLine("\n   *** Ni behöver skriva in ett nummer från Menyn! ***\n");
                        break;
                }
            }        
        }

        public static void GettingRegNumberInputs()
        {
            //var leGarage = BulkGarage.TestGarage();
            string meny =
                 "---------------------------\n"
               + "      Ta bort Fordon       \n"
               + "---------------------------\n"
               + "1: Skriv in RegNumret\n"
               + "0: Tillbaka\n";

            while (true)
            {
                Console.WriteLine(meny);

                char nextinput = ' ';
                try
                {
                    Console.Write("Skriv ert val: ");
                    nextinput = Console.ReadLine()![0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                }
                switch (nextinput)
                {
                    case '1':
                        GarageHandler.RemoveVehicle(Garage<Vehicle>.laraSoft);
                        break;
                    case '0':
                        AlterGarage();
                        break;
                    default:
                        Console.WriteLine("\n   *** Ni behöver skriva in ett nummer från Menyn! ***\n");
                        break;
                }


            }
        }
        public static void WriteReadGarage()
        {
            string meny =
                  "---------------------------\n"
                + "        Spara Fordon       \n"
                + "---------------------------\n"
                + "1: Spara Fordon på fil\n"
                + "0: Tillbaka\n";

            while (true)
            {
                Console.WriteLine(meny);

                char input = ' ';
                try
                {
                    Console.Write("Skriv ert val: ");
                    input = Console.ReadLine()![0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                }
                switch (input)
                {
                    case '1':
                        IOFiles.CheckExistingVehicleFile();
                        IOFiles.SaveVehicles();
                        break;
                    case '2':
                        GettingRegNumberInputs();
                        break;
                    case '0':
                        Meny.MenyText();
                        break;
                    default:
                        Console.WriteLine("\n   *** Ni behöver skriva in ett nummer från Menyn! ***\n");
                        break;
                }
            }
        }
        public static void Search()
        {
            string meny =
                  "---------------------------\n"
                + "        Sök Fordon       \n"
                + "---------------------------\n"
                + "1: Skriv in sökkriterier\n"
                + "0: Tillbaka\n";

            while (true)
            {
                Console.WriteLine(meny);

                char input = ' ';
                try
                {
                    Console.Write("Skriv in ert val: ");
                    input = Console.ReadLine()![0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                }
                switch (input)
                {
                    case '1':
                        GarageHandler.SearchVehicleArray();
                        break;
                    case '0':
                        Meny.MenyText();
                        break;
                    default:
                        Console.WriteLine("\n   *** Ni behöver skriva in ett nummer från Menyn! ***\n");
                        break;
                }
            }
        }
    }   
}

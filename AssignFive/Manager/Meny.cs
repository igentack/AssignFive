using AssignFive.TheGarage;
using AssignFive.TheVehicles;
using System;

namespace AssignFive.Manager
{
    public class Meny
    {
        public static string MenyText()
        {
            string meny =
             "---------------------------\n"
           + "  Välkommen till Garaget   \n"
           + "---------------------------\n"
           + "1: Garageöversikt\n"
           + "2: Lista fordon\n"
           + "3: Lägg till eller ta bort fordon\n"
           + "4: Hämta eller spara ned Garage\n"
           + "5: Sök fordon\n"
           + "0: Avsluta\n";
            
            while (true)
            {
                Console.WriteLine(meny);

                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    Console.Write("Skriv ert val: ");
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    //Console.WriteLine("Du behöver skriva in ett nummer!");
                }
                switch (input)
                {
                    case '1':                       
                        MenyHandler.CheckGarage();
                        break;
                    case '2':
                        MenyHandler.ListVehicles();
                        continue;
                    case '3':
                        MenyHandler.AlterGarage();
                        continue;
                    case '4':
                        //InstanciateNewGarage();
                        continue;
                    case '5':
                        //RecursiveEven(10);
                        continue;
                    case '6':
                        //IterativeEven(10);
                        continue;
                    case '7':
                        //IterativeFibonacci(10);
                        continue;
                    case '0':
                        Console.WriteLine($"\nFin dag nu - Välkommen åter!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\n   *** Ni behöver skriva in ett nummer från Menyn! ***\n");
                        break;
                }
            }
               
        }
    }
}


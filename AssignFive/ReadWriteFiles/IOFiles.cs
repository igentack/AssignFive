using AssignFive.TheGarage;
using AssignFive.TheVehicles;
using System.Text;

namespace AssignFive.ReadWriteFiles
{
    internal class IOFiles
    {
        private static string relativeDir = Environment.CurrentDirectory;
        private static string vehicleFile = @"\theTextFile.txt";


        internal static void CheckExistingVehicleFile()
        {
            string path = $"{relativeDir}{vehicleFile}";
            bool vehicleFileExists = File.Exists(path);
          

            if (vehicleFileExists)
            {
                Console.WriteLine("\n Filen fanns och blev uppdaterad (överskriven)\n");
            }
            else
            {
                if (!Directory.Exists(relativeDir))
                {
                    Directory.CreateDirectory(relativeDir);
                }
            }
        }
   
        internal static void SaveVehicles()
        {
            string path = $"{relativeDir}{vehicleFile}";
            StringBuilder vehicleString = new StringBuilder();
            foreach (var vehicle in Garage<Vehicle>.theGarage)
            {
                vehicleString.Append($"RegNummer:{vehicle.RegNumber};");
                vehicleString.Append($"Antal Hjul:{vehicle.NumberOfWheels};");
                vehicleString.Append($"Färg:{vehicle.Color};");

                vehicleString.Append(Environment.NewLine);
            }
            File.WriteAllText(path, vehicleString.ToString());
        }
       
    }    
}

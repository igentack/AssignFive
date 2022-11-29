using System.Xml.Linq;

namespace AssignFive.TheVehicles
{
    public abstract class Vehicle
    {
        public string RegNumber { get; set; }
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }

        public Vehicle(string regNumber, int numberOfWheels, string color)
        {
            RegNumber = regNumber;
            NumberOfWheels = numberOfWheels;
            Color = color;
        }
 
    }


}

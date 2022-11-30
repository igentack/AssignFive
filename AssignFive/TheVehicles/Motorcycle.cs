using AssignFive.InterfaceFolder;

namespace AssignFive.TheVehicles
{
    public class Motorcycle : Vehicle, IMotorcycle
    {
        //private List<dynamic> initVehicleList;

        public int CylVolume { get; set; }
        
        public Motorcycle(string regNumber, int numberOfWheels, string color, int cylVolume) : base(regNumber, numberOfWheels, color)
        {
            CylVolume = cylVolume;
        }

        public override string ToString() => $"MOTORCYCLE:\nRegistration number:\t{RegNumber}\nNumber of wheels:\t{NumberOfWheels}\nColor of Vehicle:\t{Color}\nCylinder Volume:\t{CylVolume}\n";


    }
}

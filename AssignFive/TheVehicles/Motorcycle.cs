using AssignFive.InterfaceFolder;

namespace AssignFive.TheVehicles
{
    internal class Motorcycle : Vehicle, IMotorcycle
    {
        public int CylVolume { get; set; }
        
        public Motorcycle(string regNumber, int numberOfWheels, string color, int cylVolume) : base(regNumber, numberOfWheels, color)
        {
            CylVolume = cylVolume;
        }
        public override string ToString() => $"MOTORCYCLE:\nRegistration number:\t{RegNumber}\nNumber of wheels:\t{NumberOfWheels}\nColor of Vehicle:\t{Color}\nCC Volume:\t\t{CylVolume}\n";


    }
}

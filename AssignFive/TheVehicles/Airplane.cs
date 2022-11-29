using AssignFive.InterfaceFolder;

namespace AssignFive.TheVehicles
{
    internal class Airplane : Vehicle, IAirplane
    {
        public int NumberOfEngines { get; set; }
        public Airplane(string regNumber, int numberOfWheels, string color, int numberOfEngines) : base(regNumber, numberOfWheels, color)
        {
            NumberOfEngines = numberOfEngines;
        }
        public override string ToString() => $"AIRPLANE:\nRegistration number:\t{RegNumber}\nNumber of wheels:\t{NumberOfWheels}\nColor of Vehicle:\t{Color}\nNumber of Engines:\t{NumberOfEngines}\n";

    }
}

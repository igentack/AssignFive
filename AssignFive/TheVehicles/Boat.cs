using AssignFive.InterfaceFolder;

namespace AssignFive.TheVehicles
{
    internal class Boat : Vehicle, IBoat
    {
        public int LengthFeet { get; set; }
        public Boat(string regNumber, int numberOfWheels, string color, int lengthFeet) : base(regNumber, numberOfWheels, color)
        {
            LengthFeet = lengthFeet;
        }

        public override string ToString() => $"BOAT:\nRegistration number:\t{RegNumber}\nNumber of wheels:\t{NumberOfWheels}\nColor of Vehicle:\t{Color}\nLength of Boat:\t\t{LengthFeet}\n";

    }
}

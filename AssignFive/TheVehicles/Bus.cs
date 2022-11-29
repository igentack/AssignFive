using AssignFive.InterfaceFolder;

namespace AssignFive.TheVehicles
{
    internal class Bus : Vehicle, IBus
    {
        public string FuelType { get; }
        public Bus(string regNumber, int numberOfWheels, string color, string fuelType) : base(regNumber, numberOfWheels, color)
        {
            FuelType = fuelType;
        }
        public override string ToString() => $"BUS:\nRegistration number:\t{RegNumber}\nNumber of wheels:\t{NumberOfWheels}\nColor of Vehicle:\t{Color}\nFueltype:\t\t{FuelType}\n";

    }
}

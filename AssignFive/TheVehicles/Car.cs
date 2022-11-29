using AssignFive.InterfaceFolder;

namespace AssignFive.TheVehicles
{
    internal class Car : Vehicle, ICar
    {
        public int NumberOfSeats { get; set; }
        public Car(string regNumber, int numberOfWheels, string color, int numberOfSeats) : base(regNumber, numberOfWheels, color)
        {
            NumberOfSeats = numberOfSeats;
        }

        public override string ToString() => $"CAR:\nRegistration number:\t{RegNumber}\nNumber of wheels:\t{NumberOfWheels}\nColor of Vehicle:\t{Color}\nNumber of Seats:\t{NumberOfSeats}\n";


    }

}

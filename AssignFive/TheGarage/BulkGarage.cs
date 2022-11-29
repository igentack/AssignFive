using AssignFive.TheVehicles;
using System.Collections;
using System.Collections.ObjectModel;


namespace AssignFive.TheGarage
{
    public class BulkGarage 
    {
        
        public static Garage<Vehicle> TestGarage(Garage<Vehicle> theGarage)
        {
            Airplane air10 = new("ABC925", 2, "Yellow", 6);
            Motorcycle cycle2 = new("CBA927", 2, "Red", 900);
            Car car1 = new("LKJ258", 4, "Brown", 2);
            Motorcycle cycle1 = new("GGD725", 2, "Violet", 850);
            Boat boat2 = new("CDA700", 4, "GreyBlue", 800000);
            Bus bus1 = new("QQC999", 4, "Grey", "Diesel");

            theGarage.Park(cycle1);
            theGarage.Park(boat2);
            theGarage.Park(cycle2);
            theGarage.Park(car1);
            theGarage.Park(air10);
            theGarage.Park(bus1);
            Console.WriteLine("\n   *** Garaget populerades med 6 gäster! ***\n");
            return Garage<Vehicle>.laraSoft;
        }
    }
}

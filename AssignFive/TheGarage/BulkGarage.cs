using AssignFive.TheVehicles;
using System.Collections;
using System.Collections.ObjectModel;


namespace AssignFive.TheGarage
{
    public class BulkGarage 
    {
        public static Garage<Vehicle> TestGarage(Garage<Vehicle> TheGarage)
        {
            Airplane air10 = new("ABC925", 2, "Red", 6);
            Motorcycle cycle2 = new("ABC925", 2, "Red", 900);
            Car car1 = new("LKJ258", 4, "Red", 2);
            Motorcycle cycle1 = new("ABC725", 2, "Violet", 850);
            Boat boat2 = new("CDA700", 4, "GreyBlue", 800000);
            Bus bus1 = new("QQC999", 4, "GreyBlue", "Diesel");
           
            //Garage<Vehicle> leGarage = new Garage<Vehicle>(10);

            TheGarage.Park(cycle1);
            TheGarage.Park(boat2);
            TheGarage.Park(cycle2);
            TheGarage.Park(car1);
            TheGarage.Park(air10);
            TheGarage.Park(bus1);
            return Garage<Vehicle>.laraSoft;
        }
    }
}

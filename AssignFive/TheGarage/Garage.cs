using AssignFive.TheVehicles;
using System.Collections;
using System.Runtime.CompilerServices;

namespace AssignFive.TheGarage
{ 
    public class Garage<T> : IEnumerable<T>  where T: Vehicle
    {

        private static T[]? vehicles; 
       

        public Garage(int capacity)
        {   
            vehicles = new T[capacity];
        }

        public static Garage<Vehicle> theGarage = new Garage<Vehicle>(8);
  

        public static Garage<Vehicle> OwnArr(int index)
        {
            Garage<Vehicle>theGarage = new Garage<Vehicle>(index); 
            return theGarage;
        }

        public static Garage<Vehicle> laraSoft
        {
            get { return theGarage; }

        }

        public bool Park(T newVehicle)
        {

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = newVehicle;
                    return true;
                }
            }
            return false;              
        }

        public bool Unpark(string licenseNr)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null && vehicles[i].RegNumber.ToUpper() == licenseNr)
                {
                    vehicles[i] = null;
                    return true;
                }
            }
            return false;
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle != null)
                {
                    yield return vehicle;                 
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        internal void Park(string v1, int v2, string v3)
        {
            //throw new NotImplementedException();
        }
    }
}

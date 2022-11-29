using AssignFive.TheVehicles;
using System.Collections;
using System.Runtime.CompilerServices;

namespace AssignFive.TheGarage
{ 
    public class Garage<T> : IEnumerable<T>  where T: Vehicle
    {

        private static T[] vehicles ;  //{ get; set; }

        public Garage(int capacity)
        {   
            vehicles = new T[capacity];
        }

        private static Garage<Vehicle> theGarage = new Garage<Vehicle>(10);
        
        public static Garage<Vehicle> laraSoft
        {
            get { return theGarage; }

        }
        public T this[int index] => vehicles[index];

   /*     public static Garage<Vehicle> GetInstance()
        {
            if (Garage<Vehicle>.vehicles == null)
            {
                Garage<Vehicle> laraSoft = new Garage<Vehicle>(12);
                return laraSoft;
            }
        }*/

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
                if (vehicles[i] != null && vehicles[i].RegNumber == licenseNr)
                {
                    vehicles[i] = null;
                    return true;
                }
            }
            return false;
        }

     /*   private static void InitArray(int arrayLenght)
        {
      
            if (arrayLenght == 0)
            {
                BulkGarage.TestGarage();         
            }
            else
            {
                Garage<Vehicle> leGarage = new Garage<Vehicle>(arrayLenght);             
            }
        }*/

        
        public static void InitNewArray()
       


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

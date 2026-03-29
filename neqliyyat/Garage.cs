using System;
using System.Collections.Generic;
using System.Text;

namespace neqliyyat
{
    public class Garage
    {
        private List <Vehicle> vehicles = new List <Vehicle> ();
        public void AddVehicle (Vehicle v)
        {
            vehicles.Add (v);
        }
        public void ShowAllVehicles()
        {
            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine(v.GetInfo());
            }
        }
    }
}

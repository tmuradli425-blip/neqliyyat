using System;
using neqliyyat;

namespace neqliyyat
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage myGarage = new Garage();
            Console.WriteLine("--- Masin melumatlari ---");
            Console.Write("Brand: "); string cB = Console.ReadLine();
            Console.Write("Model: "); string cM = Console.ReadLine();
            Console.Write("Year: "); int cY = int.Parse(Console.ReadLine());
            Car myCar = new Car(cB, cM, cY, "Benzin", 4);
            myGarage.AddVehicle(myCar);
            Console.WriteLine("\n--- Motosiklet melumatlari ---");
            Console.Write("Brand: "); string mB = Console.ReadLine();
            Console.Write("Model: "); string mM = Console.ReadLine();
            Motorcycle myMoto = new Motorcycle(mB, mM, 2022, "Benzin", 1000);
            myGarage.AddVehicle(myMoto);
            Console.WriteLine("\n--- Yuk masini melumatlari ---");
            Console.Write("Brand: "); string tB = Console.ReadLine();
            Truck myTruck = new Truck(tB, "FH16", 2021, 20);
            myGarage.AddVehicle(myTruck);
            Console.WriteLine("\n--- Netice ---");
            myGarage.ShowAllVehicles();
            Console.ReadLine();
        }
    }
}


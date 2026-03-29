using System;
using System.Collections.Generic;
using System.Text;

namespace neqliyyat
{
  public class Car : Vehicle
    {
        private string _fuelType;
        private int _doorCount;
        public string FuelType
        {
            get { return _fuelType; }
            set { _fuelType = value; }
        }
        public int DoorCount
        {
            get { return _doorCount; }
            set { _doorCount = value; }
        }
        public Car(string brand, string model, int year, string fuelType, int doorCount) : base(brand, model, year)
        {
            this.FuelType = fuelType;
            this.DoorCount = doorCount;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $", Yanacaq: {FuelType}, Qapi sayi: {DoorCount}";
        }
      }
    }


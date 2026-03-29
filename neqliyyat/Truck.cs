using System;
using System.Collections.Generic;
using System.Text;

namespace neqliyyat
{
    public class Truck : Vehicle
    {
        private int _loadCapacity;
        public int LoadCapacity
        {
            get { return _loadCapacity; }
            set { _loadCapacity = value; }
        }
        public Truck(string brand, string model, int year, int loadCapacity) : base(brand, model, year)
        {
            this.LoadCapacity = loadCapacity;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $", Yuk tutumu: {LoadCapacity}ton";
        }
    }
}
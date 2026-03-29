using System;
using System.Collections.Generic;
using System.Text;

namespace neqliyyat
{
    public class Motorcycle : Vehicle
    {
        private string _fuelType;
        private int _engineSize;
        public string FuelType
        {
            get { return _fuelType; }
            set { _fuelType = value; } 
        }
        public int EngineSize
        {
            get { return _engineSize; }
            set { _engineSize = value; }
        }
        public Motorcycle(string brand, string model, int year, string fuelType, int engineSize) : base(brand, model, year)
        {
            this.FuelType = fuelType;
            this.EngineSize = engineSize;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $",Yanacaq: {FuelType} , Muherrik: {EngineSize}cc";
        }
    }
}

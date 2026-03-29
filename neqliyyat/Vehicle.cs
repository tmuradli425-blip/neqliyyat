using System;
using System.Collections.Generic;
using System.Text;

namespace neqliyyat
{
   public class Vehicle
    {
        private string _brand;
        private string _model;
        private int _year;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 1900)
                {
                    Console.WriteLine("1900-den kicik il ola bilmez");
                    _year = 1900;
                }
                else
                {
                    _year = value;
                }
            }
        }
        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
        public virtual string GetInfo()
        {
            return $"{Year} {Brand} {Model}";
        }
    }
}

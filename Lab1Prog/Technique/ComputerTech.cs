using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Prog.Technique
{
    public class ComputerTech
    {
        private string _manufacturer;

        public string Manufacturer
        {
            get { return _manufacturer; }
            set {
                ArgumentNullException.ThrowIfNull(value);
                _manufacturer = value; 
            }
        }

        private int _year;

        public int Year
        {
            get { return _year; }
            set
            {
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value, DateTime.Now.Year, "Year");
                ArgumentOutOfRangeException.ThrowIfNegative(value, "Year");
                _year = value;
            }
        }

        

        private int _amountStock;

        public int AmountStock
        {
            get { return _amountStock; }
            set {
                ArgumentOutOfRangeException.ThrowIfNegative(value, "StorageCapacity");
                _amountStock = value; 
            }
        }

        private double _price;

        public double Price
        {
            get { return _price; }
            set {
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value, "Price");
                _price = value; 
            }
        }

        public ComputerTech()
        {
            _manufacturer = string.Empty;
            _year = 0;
            _amountStock = 0;
            _price = 0;
        }

        public ComputerTech(string manufacturer, int year, int storageCapacity, double price) : this()
        {
            Manufacturer = manufacturer;
            Year = year;
            AmountStock = storageCapacity;
            Price = price;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Manufacturer: {_manufacturer}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Amount of stock: {AmountStock}");
        }
    }
}

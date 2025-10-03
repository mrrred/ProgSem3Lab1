using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Prog.Technique.Monitor
{
    class Display : ComputerTech
    {
        private double _screenSize;

        public double ScreenSize
        {
            get { return _screenSize; }
            set { 
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value, "ScreenSize");
                _screenSize = value; 
            }
        }

        private int _refreshRate;

        public int RefreshRate
        {
            get { return _refreshRate; }
            set {
                ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value, "RefreshRate");
                _refreshRate = value; 
            }
        }

        public Display() : base()
        {
            _screenSize = 24;
            _refreshRate = 60;
        }

        public Display(string? manufacturer, int year, int storageCapacity, double price, double screenSize, int refreshRate)
            : base(manufacturer, year, storageCapacity, price)
        {
            ScreenSize = screenSize;
            RefreshRate = refreshRate;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Screen Size: {ScreenSize} inches");
            Console.WriteLine($"Refresh Rate: {RefreshRate} Hz");
        }

    }
}

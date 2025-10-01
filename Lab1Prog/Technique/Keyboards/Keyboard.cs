using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Prog.Technique.Keyboards
{
    class Keyboard : ComputerTech
    {
        private string _layout;

        public string Layout
        {
            get { return _layout; }
            set {
                ArgumentNullException.ThrowIfNullOrEmpty(value);
                _layout = value;
            }
        }

        public Keyboard() : base()
        {
            _layout = "QWERTY";
        }

        public Keyboard(string manufacturer, int year, int storageCapacity, double price, string layout) 
            : base(manufacturer, year, storageCapacity, price)
        {
            Layout = layout;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Keyboard Layout: {Layout}");
        }
    }
}

using Lab1Prog.Technique;
using Lab1Prog.Technique.Keyboards;
using Lab1Prog.Technique.Monitors;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Lab1Prog.TestProgram
{
    public class Program
    {
        static public void InputComputeTechInfo(ref string? manufacturer, ref int year, ref int storageCapacity, ref double price)
        {
            Console.WriteLine("Введите производителя: ");
            manufacturer = Console.ReadLine();
            Console.WriteLine("Введите год: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите объем: ");
            storageCapacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цену: ");
            price = Convert.ToDouble(Console.ReadLine());
        }

        static public void InputMonitorInfo(ref double screenSize, ref int refreshRate)
        {
            Console.WriteLine("Введите размер экрана (в дюймах): "); ;
            screenSize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите частоту обновления (в Гц): "); ;
            refreshRate = Convert.ToInt32(Console.ReadLine());
        }

        static public void InputKeyboardInfo(ref string? layout)
        {
            Console.WriteLine("Введите раскладку клавиатуры: "); ;
            layout = Console.ReadLine();
        }

        static public void Main(string[] args)
        {
            var devicesList = new List<ComputerTech>();

            char choice;
            string? manufacturer = "";
            int year = 0, val = 0;
            double price = 1;

            do
            {
                Console.Write("Выберите тип устройства для создания (T - Техника, M - Монитор, K - Клавиатура, E - Выход): ");
                choice = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                ComputerTech? newDevice = null;

                switch (choice)
                {
                    case 'T':
                        InputComputeTechInfo(ref manufacturer, ref year, ref val, ref price);
                        newDevice = new ComputerTech(manufacturer ?? "", year, val, price);
                        break;
                    case 'M':
                        double screenSize = 1;
                        int refreshRate = 1;
                        InputComputeTechInfo(ref manufacturer, ref year, ref val, ref price);
                        InputMonitorInfo(ref screenSize, ref refreshRate);
                        newDevice = new Display(manufacturer ?? "", year, val, price, screenSize, refreshRate);
                        break;
                    case 'K':
                        string? layout = "";
                        InputComputeTechInfo(ref manufacturer, ref year, ref val, ref price);
                        InputKeyboardInfo(ref layout);
                        newDevice = new Keyboard(manufacturer ?? "", year, val, price, layout ?? "QWERTY");
                        break;
                    case 'E':
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Неверный выбор");
                        continue;
                }

                if (newDevice != null)
                {
                    devicesList.Add(newDevice);
                }

            } while (choice != 'E');

            Console.Clear();
            Console.WriteLine("Печать устройств в списке:"); ;
            Console.WriteLine("----------------------"); ;
            foreach (var device in devicesList)
            {
                device.Print();
                Console.WriteLine("----------------------");
            }
        }
    }
}
using Lab1Prog.Technique;
using Lab1Prog.Technique.Keyboards;
using Lab1Prog.Technique.Monitor;
using System;
using System.Collections.Generic;

namespace Lab1Prog.TestProgram
{
    class Program
    {
        static public void Main(string[] args)
        {
            var devicesList = new List<ComputerTech>();

            char choice;
            string? manufacturer;
            int year, val;
            double price;
            string? layout; // перемещаем объявление переменной сюда

            do
            {
                Console.Write("Выберите тип устройства для создания (T - Техника, M - Монитор, K - Клавиатура, E - Выход): ");
                choice = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                ComputerTech? newDevice = null;

                switch (choice)
                {
                    case 'T':
                        Console.WriteLine("Введите производителя: ");
                        manufacturer = Console.ReadLine();
                        Console.WriteLine("Введите год: ");
                        year = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите объем: ");
                        val = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите цену: ");
                        price = Convert.ToDouble(Console.ReadLine());
                        newDevice = new ComputerTech(manufacturer, year, val, price);
                        break;
                    case 'M':
                        double screenSize; 
                        int refreshRate;
                        Console.WriteLine("Введите производителя: ");
                        manufacturer = Console.ReadLine();
                        Console.WriteLine("Введите год: ");
                        year = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите объем: ");
                        val = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите цену: ");
                        price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите размер экрана (в дюймах): "); ;
                        screenSize = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите частоту обновления (в Гц): "); ;
                        refreshRate = Convert.ToInt32(Console.ReadLine());
                        newDevice = new Display(manufacturer, year, val, price, screenSize, refreshRate);
                        break;
                    case 'K':
                        Console.WriteLine("Введите производителя: ");
                        manufacturer = Console.ReadLine();
                        Console.WriteLine("Введите год: ");
                        year = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите объем: ");
                        val = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите цену: ");
                        price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите раскладку клавиатуры: "); ;
                        layout = Console.ReadLine();
                        newDevice = new Keyboard(manufacturer, year, val, price, layout);
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._1_Mansion
{
    class Program
    {
        static void Main(string[] args)
        {
            Mansion mansion_1 = new Mansion(600, 2, 8, 1);    //Создаём дом высота 6м, 2 этажа, 8 квартир, 1 подъезд
            Mansion mansion_2 = new Mansion(800, 4, 16, 4);   //Создаём дом высота 6м, 2 этажа, 16 квартир, 2 подъезда

            mansion_1.PrintMansion();
            mansion_2.PrintMansion();

            Console.WriteLine($"Высота этажей в доме №{mansion_1.GetId()}: {mansion_1.GetStoreysHeight()} см, " +
                $"Кол-во квартир на этаже: {mansion_1.GetApartmentsInStoreys()}, Кол-во квартир в подъезде {mansion_1.GetApartmentsInEntrances()}");

            Console.WriteLine();

            Console.WriteLine($"Высота этажей в доме №{mansion_2.GetId()}: {mansion_2.GetStoreysHeight()} см, " +
                $"Кол-во квартир на этаже: {mansion_2.GetApartmentsInStoreys()}, Кол-во квартир в подъезде {mansion_2.GetApartmentsInEntrances()}");

            Console.ReadLine();

        }
    }
}

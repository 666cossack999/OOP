using System;
using System.Collections;
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
            //Создаём дома
            Creator.CreateBuild(1000, 2, 4, 2);
            Creator.CreateBuild(600, 5, 2, 3);
            Creator.CreateBuild(1500, 5, 2, 3);
            Creator.CreateBuild(2000, 4, 2, 3);
            Creator.CreateBuild(3000, 4, 2, 4);
            Creator.CreateBuild(4000, 4, 2, 5);
            Creator.CreateBuild(5000, 4, 6, 2);
            Creator.CreateBuild(6000, 4, 7, 2);
            Creator.CreateBuild(7000, 4, 8, 2);
            Creator.CreateBuild(8000, 4, 9, 2);
            Creator.CreateBuild(9000, 10, 2, 2);


            Creator.ht.Remove(3);
            Creator.ht.Remove(6);
            Creator.ht.Remove(7);

            //получаем коллекцию ключей из хэш-таблицы
            ICollection keys = Creator.ht.Keys;
            

            //создаём массив объектов
            var builds = new Mansion[keys.Count];
            //заполняем массив нашими домами, выводим инфо о домах на консоль            

            
            for (int i = 0, j = 1; i < keys.Count; i++)
            {
                
                if (Creator.ht[i+j] != null)
                {
                    builds[i] = (Mansion)Creator.ht[i + j];
                    builds[i].PrintMansion();
                }
                else
                {
                    while (Creator.ht[i + j] == null)
                    {
                        j++;
                    }
                    builds[i] = (Mansion)Creator.ht[i + j];
                    builds[i].PrintMansion();
                }
                
            }
           
            Console.WriteLine($"Высота этажа дома №{builds[1].GetId()}: {builds[1].GetStoreysHeight()}");
            Console.WriteLine($"Высота этажа дома №{builds[3].GetId()}: {builds[3].GetStoreysHeight()}");

            Console.ReadLine();
            

        }
    }
}

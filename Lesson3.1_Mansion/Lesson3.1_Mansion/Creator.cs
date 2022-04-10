using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._1_Mansion
{
    static class Creator
    {
        public static Hashtable ht = new Hashtable();

        /// <summary>
        /// Создаёт объект класса Mansion
        /// </summary>
        /// <param name="height">высота</param>
        /// <returns>объект</returns>
        static public void CreateBuild (int height)
        {
            Mansion build = new Mansion(height);
            ht.Add(build.GetId(), build);
        }

        /// <summary>
        /// Создаёт объект класса Mansion
        /// </summary>
        /// <param name="height">высота</param>
        /// <param name="storeys">этажность</param>
        /// <returns>объект</returns>
        static public void CreateBuild(int height, int storeys)
        {
            Mansion build = new Mansion(height, storeys);
            ht.Add(build.GetId(), build);
        }

        /// <summary>
        /// Создаёт объект класса Mansion
        /// </summary>
        /// <param name="height">высота</param>
        /// <param name="storeys">этажность</param>
        /// <param name="apartments">кол-во квартир</param>
        /// <returns>объект</returns>
        static public void CreateBuild(int height, int storeys, int apartments)
        {
            Mansion build = new Mansion(height, storeys, apartments);
            ht.Add(build.GetId(), build);
        }

        /// <summary>
        /// Создаёт объект класса Mansion
        /// </summary>
        /// <param name="height">высота</param>
        /// <param name="storeys">этажность</param>
        /// <param name="apartments">кол-во квартир</param>
        /// <param name="entrances">кол-во подъездов</param>
        /// <returns>объект</returns>
        static public void CreateBuild(int height, int storeys, int apartments, int entrances)
        {
            Mansion build = new Mansion(height, storeys, apartments, entrances);
            ht.Add(build.GetId(), build);
        }

    }
}

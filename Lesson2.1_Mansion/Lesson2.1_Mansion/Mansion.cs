using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._1_Mansion
{
    class Mansion
    {
        private static int id;
        private int _mansionNumber; //номер здания
        private int _height;        //высота
        private int _storeys;       //этажность
        private int _apartments;    //кол-во квартир
        private int _entrances;     //кол-во подъездов

        public Mansion() : this(0)
        {
        }
        public Mansion(int height) : this(height, 0)
        {
        }

        public Mansion(int height, int storeys) : this(height, storeys,0)
        {
        }

        public Mansion(int height, int storeys, int apartments) : this(height, storeys, apartments,0)
        {
        }

        public Mansion(int height, int storeys, int apartments, int entrances)
        {
            _mansionNumber = SetId();
            _height = height;
            _storeys = storeys;
            _apartments = apartments;
            _entrances = entrances;
        }



        /// <summary>
        /// Создаёт уникальный ID
        /// </summary>
        /// <returns></returns>
        public int SetId()
        {
            _mansionNumber = id++;
            return _mansionNumber;
        }
    }
}

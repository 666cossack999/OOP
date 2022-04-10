using System;

namespace Lesson3._1_Mansion
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
        public Mansion(int height, int storeys) : this(height, storeys, 0)
        {
        }

        public Mansion(int height, int storeys, int apartments) : this(height, storeys, apartments, 0)
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

        public void SetHeight(int height) { _height = height; }

        public void SetStoreys(int storeys) { _storeys = storeys; }

        public void SetApartmens(int apartmens) { _apartments = apartmens; }

        public void SetEntrances(int entrances) { _entrances = entrances; }

        public void PrintId() { Console.WriteLine($"Номер дома: {_mansionNumber}"); }

        public void PrintHeight() { Console.WriteLine($"Высота дома: {_height} см"); }

        public void PrintStoreys() { Console.WriteLine($"Количество этажей: {_storeys}"); }

        public void PrintApartments() { Console.WriteLine($"Количество квартир: {_apartments}"); }

        public void PrintEntrances() { Console.WriteLine($"Количество подъездов: {_entrances}"); }

        private void PrintLine()
        {
            Console.WriteLine("\n=======================================\n");
        }

        /// <summary>
        /// Вычисляет высоту этажа
        /// </summary>
        /// <returns>Высота этажа</returns>
        public int GetStoreysHeight()
        {
            return _height / _storeys;
        }

        /// <summary>
        /// Вычисляет кол-во квартир в подъезде
        /// </summary>
        /// <returns>кол-во квартир в подъезде</returns>
        public int GetApartmentsInEntrances()
        {
            return _apartments / _entrances;
        }

        /// <summary>
        /// Вычисляет кол-во квартир на этаже
        /// </summary>
        /// <returns></returns>
        public int GetApartmentsInStoreys()
        {
            return _apartments / _storeys;
        }

        public void PrintMansion()
        {
            PrintId();
            PrintHeight();
            PrintStoreys();
            PrintApartments();
            PrintEntrances();
            PrintLine();
        }

        /// <summary>
        /// Создаёт уникальный ID
        /// </summary>
        /// <returns></returns>
        private int SetId()
        {
            _mansionNumber = ++id;
            return _mansionNumber;
        }

        public int GetId()
        {
            return _mansionNumber;
        }
    }
}

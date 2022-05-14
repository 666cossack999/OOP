using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._1Calc
{
    class RationalNumber
    {
        private int _numerator;
        private int _denominator;

        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть 0");

            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }

            _numerator = numerator;
            _denominator = denominator;

            Minimize();
        }

        /// <summary>
        /// Находим наибольший общий делитель алгоритмом Евклида
        /// </summary>
        /// <param name="number1">1й знаменатель</param>
        /// <param name="number2">2й знаменатель</param>
        /// <returns></returns>
        private static int GetNOD(int number1, int number2)
        {
            if (number2 == 0)
                return number1;
            else
                return GetNOD(number2, number1 % number2);
        }

        /// <summary>
        /// Сокращаем дробь до наименьших значений
        /// </summary>
        private void Minimize()
        {
            int NOD = RationalNumber.GetNOD(_numerator, _denominator);
            _numerator /= NOD;
            _denominator /= NOD;
        }

        /// <summary>
        /// Преобразует обект в строку
        /// </summary>
        /// <returns>строка</returns>
        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }

        /// <summary>
        /// Складывает две дроби
        /// </summary>
        /// <param name="number1">первая дробь</param>
        /// <param name="number2">вторая дробь</param>
        /// <returns>Сумма двух дробей</returns>
        public static RationalNumber operator +(RationalNumber number1, RationalNumber number2)
        {
           return new RationalNumber((number1._numerator * number2._denominator) + (number2._numerator * number1._denominator), number1._denominator * number2._denominator);
        }

        /// <summary>
        /// Вычитает из первой дроби вторую
        /// </summary>
        /// <param name="number1">первая дробь</param>
        /// <param name="number2">вторая дробь</param>
        /// <returns>Разность двух дробей</returns>
        public static RationalNumber operator -(RationalNumber number1, RationalNumber number2)
        {
            return new RationalNumber((number1._numerator * number2._denominator) - (number2._numerator * number1._denominator), number1._denominator * number2._denominator);
        }

        /// <summary>
        /// Умножает дроби
        /// </summary>
        /// <param name="number1">первая дробь</param>
        /// <param name="number2">вторая дробь</param>
        /// <returns>Произведение двух дробей</returns>
        public static RationalNumber operator *(RationalNumber number1, RationalNumber number2)
        {
            return new RationalNumber(number1._numerator * number2._numerator, number1._denominator * number2._denominator);
        }

        /// <summary>
        /// Делит первую дробь на вторую
        /// </summary>
        /// <param name="number1">первая дробь</param>
        /// <param name="number2">вторая дробь</param>
        /// <returns>Частное от двух дробей</returns>
        public static RationalNumber operator /(RationalNumber number1, RationalNumber number2)
        {
            return new RationalNumber(number1._numerator * number2._denominator, number1._denominator * number2._numerator);
        }

        //Оператор <
        public static bool operator <(RationalNumber number1, RationalNumber number2)
        {
            RationalNumber number3 = new RationalNumber(number1._numerator * number2._denominator, number1._denominator * number2._denominator);    //Приводим к общему
            RationalNumber number4 = new RationalNumber(number2._numerator * number1._denominator, number1._denominator * number2._denominator);    //знаменателю

            //Сравниваем
            if (number3._numerator < number4._numerator)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Оператор <=
        public static bool operator <=(RationalNumber number1, RationalNumber number2)
        {
            RationalNumber number3 = new RationalNumber(number1._numerator * number2._denominator, number1._denominator * number2._denominator);    //Приводим к общему
            RationalNumber number4 = new RationalNumber(number2._numerator * number1._denominator, number1._denominator * number2._denominator);    //знаменателю

            //Сравниваем
            if (number3._numerator <= number4._numerator)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Оператор >=
        public static bool operator >=(RationalNumber number1, RationalNumber number2)
        {
            RationalNumber number3 = new RationalNumber(number1._numerator * number2._denominator, number1._denominator * number2._denominator);    //Приводим к общему
            RationalNumber number4 = new RationalNumber(number2._numerator * number1._denominator, number1._denominator * number2._denominator);    //знаменателю

            //Сравниваем
            if (number3._numerator >= number4._numerator)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Оператор >
        public static bool operator >(RationalNumber number1, RationalNumber number2)
        {
            RationalNumber number3 = new RationalNumber(number1._numerator * number2._denominator, number1._denominator * number2._denominator);    //Приводим к общему
            RationalNumber number4 = new RationalNumber(number2._numerator * number1._denominator, number1._denominator * number2._denominator);    //знаменателю

            //Сравниваем
            if (number3._numerator > number4._numerator)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Оператор ==
        public static bool operator ==(RationalNumber number1, RationalNumber number2)
        {
            RationalNumber number3 = new RationalNumber(number1._numerator * number2._denominator, number1._denominator * number2._denominator);    //Приводим к общему
            RationalNumber number4 = new RationalNumber(number2._numerator * number1._denominator, number1._denominator * number2._denominator);    //знаменателю

            //Сравниваем
            if (number3._numerator == number4._numerator)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Оператор !=
        public static bool operator !=(RationalNumber number1, RationalNumber number2)
        {
            RationalNumber number3 = new RationalNumber(number1._numerator * number2._denominator, number1._denominator * number2._denominator);    //Приводим к общему
            RationalNumber number4 = new RationalNumber(number2._numerator * number1._denominator, number1._denominator * number2._denominator);    //знаменателю

            //Сравниваем
            if (number3._numerator != number4._numerator)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Инкремент дроби
        /// </summary>
        /// <param name="number">Дробь</param>
        /// <returns>Результат инкремента</returns>
        public static RationalNumber operator ++(RationalNumber number)
        {
            return new RationalNumber(number._numerator + number._denominator, number._denominator);
        }

        /// <summary>
        /// Декремент дроби
        /// </summary>
        /// <param name="number">Дробь</param>
        /// <returns>Результат декремента</returns>
        public static RationalNumber operator --(RationalNumber number)
        {
            return new RationalNumber(number._numerator - number._denominator, number._denominator);
        }
    }
}

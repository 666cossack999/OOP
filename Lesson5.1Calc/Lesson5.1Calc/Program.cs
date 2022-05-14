using System;

namespace Lesson5._1Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber number1 = new RationalNumber(4, 6);
            RationalNumber number2 = new RationalNumber(1, 5);
            RationalNumber number3 = new RationalNumber(2, 10);

            RationalNumber number = number1 + number2;
            Console.WriteLine($"{number1.ToString()} + {number2.ToString()} = {number.ToString()}\n");

            number = number1 - number2;
            Console.WriteLine($"{number1.ToString()} - {number2.ToString()} = {number.ToString()}\n");

            number = number1 * number2;
            Console.WriteLine($"{number1.ToString()} * {number2.ToString()} = {number.ToString()}\n");

            number = number1 / number2;
            Console.WriteLine($"{number1.ToString()} / {number2.ToString()} = {number.ToString()}\n");

            number1++;
            Console.WriteLine($"number1++ = {number1.ToString()} \n");

            number1--;
            Console.WriteLine($"number1-- = {number1.ToString()} \n");

            number1--;
            Console.WriteLine($"number1-- = {number1.ToString()} \n");

            bool result = number2 < number3;
            Console.Write($"{number1.ToString()} < {number2.ToString()} ");

            if (result)
            {
                Console.WriteLine("Истина");
            }
            else
            {
                Console.WriteLine("Ложь");
            }


            result = number2 <= number3;
            Console.Write($"{number1.ToString()} <= {number2.ToString()} ");

            if (result)
            {
                Console.WriteLine("Истина");
            }
            else
            {
                Console.WriteLine("Ложь");
            }


            result = number1 > number2;
            Console.Write($"{number1.ToString()} > {number2.ToString()} ");

            if (result)
            {
                Console.WriteLine("Истина");
            }
            else
            {
                Console.WriteLine("Ложь");
            }


            result = number1 >= number2;
            Console.Write($"{number1.ToString()} >= {number2.ToString()} ");

            if (result)
            {
                Console.WriteLine("Истина");
            }
            else
            {
                Console.WriteLine("Ложь");
            }


            result = number1 == number2;
            Console.Write($"{number1.ToString()} == {number2.ToString()} ");

            if (result)
            {
                Console.WriteLine("Истина");
            }
            else
            {
                Console.WriteLine("Ложь");
            }


            result = number1 != number2;
            Console.Write($"{number1.ToString()} != {number2.ToString()} ");

            if (result)
            {
                Console.WriteLine("Истина");
            }
            else
            {
                Console.WriteLine("Ложь");
            }



        }
    }
}

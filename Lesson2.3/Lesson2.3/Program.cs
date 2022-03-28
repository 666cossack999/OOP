using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._3
{
    class Program
    {
        /// <summary>
        /// Читает файл, записывает данные в массив
        /// </summary>
        /// <returns>Массив строк ФИО & email</returns>
        static string[] ReadText()
        {
            //путь к файлу
            string path = "contact.txt";
            //открываем файл для чтения
            StreamReader reader = new StreamReader(path);
            //прочитать файл
            string text = reader.ReadToEnd();
            //закрыть файл
            reader.Close();
            string[] contacts = text.Split('\r');

            return contacts;
            
        }
        /// <summary>
        /// Дописывает email адреса в новый txt файл mails.txt
        /// </summary>
        /// <param name="str"></param>
        static void WriteText(string[] str)
        {
            string path = "mails.txt";
            File.AppendAllLines(path,str);
        }
        /// <summary>
        /// Принимает строку "ФИО & email" и перезаписывает её "email" 
        /// </summary>
        /// <param name="s">ссылка на строку</param>
        public static void SearchMail(ref string s)
        {
            string[] mails = s.Split('&');

            s = mails[1];
        }
           
        static void Main(string[] args)
        {
            //считываем файл
            string[] contacts = ReadText();
            
            //выделяем из файла email адреса
            for (int i = 0; i < contacts.Length; i++)
            {
               SearchMail(ref contacts[i]);
            }
            //создаём файл с адресами
            WriteText(contacts);

            Console.ReadLine();
        }
    }
}

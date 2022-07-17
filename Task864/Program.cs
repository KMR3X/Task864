using System;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace Task864
{
    class Program
    {
        static void Main()
        {

            string path = "Контакты.xml";

            Console.WriteLine("Создание контакта. \nВведите: ");


            Console.Write("1. Ф.И.О. контакта: ");
            string name = Console.ReadLine();

            Console.Write("\n2. Улицу проживания: ");
            string street = Console.ReadLine();

            Console.Write("\n3. Номер дома: ");
            string houseNumber = Console.ReadLine();

            Console.Write("\n4. Номер квартиры: ");
            string flatNumber = Console.ReadLine();

            Console.Write("\n5. Мобильный телефон контакта: ");
            string mobilePhone = Console.ReadLine();

            Console.Write("\n6. Домашний телефон контакта: ");
            string flatPhone = Console.ReadLine();

            Person p = new Person(name, street, houseNumber, flatNumber, mobilePhone, flatPhone);

            Console.WriteLine(p.XmlPrint());
            Save(path, p);

            Console.ReadLine();
        }

        /// <summary>
        /// Метод, сохраняющий Person в .xml файл.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="p"></param>
        static void Save(string path, Person p)
        {
            StreamWriter sw = new StreamWriter(path, false);

            sw.Write(p.XmlPrint());

            sw.Close();
        }
    }
}
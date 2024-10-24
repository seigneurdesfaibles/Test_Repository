using System;
using System.IO;
using System.Xml.Serialization;

namespace Practice04
{
    public class Person
    {
        public string Name { get; set; } = "Undefined";
        public int Age { get; set; } = 1;

        public Person() { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class class1
    {
        static void Main(string[] args)
        {
            // Створюємо об'єкт Person
            Person person = new Person("Tom", 37);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

            // Визначаємо шлях до файлу
            string filepath = "C:\\Users\\User\\OneDrive\\Рабочий стол\\op.txt";

            // Серіалізація об'єкта в XML і запис у файл
            using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, person);
                Console.WriteLine("Object has been serialized");
            }

            // Десеріалізація об'єкта з файлу XML
            using (FileStream fs = new FileStream(filepath, FileMode.Open))
            {
                Person dperson = xmlSerializer.Deserialize(fs) as Person;
                if (dperson != null)
                {
                    Console.WriteLine($"Name: {dperson.Name}  Age: {dperson.Age}");
                }
            }
        }
    }
}

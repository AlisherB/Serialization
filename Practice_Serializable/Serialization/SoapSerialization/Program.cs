using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace SoapSerialization
{
    class Program
    {
        private static string path = @"C:\data";

        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>
            {
                new Person
                {
                    Name = "Alisher",
                    Surname = "Bekmukhambet",
                    Telephone = "12345789",
                    Year = 1995
                },
                new Person
                {
                    Name = "Ivan",
                    Surname = "Petrovich",
                    Telephone = "987654321",
                    Year = 1994
                }
            };
            SoapFormatter formatter = new SoapFormatter();
            if (Directory.Exists(path))
            {
                using (FileStream stream = new FileStream(path + @"\person.csv", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(stream, persons);
                }
            }
        }
    }
}

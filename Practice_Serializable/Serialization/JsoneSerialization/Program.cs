using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;

namespace JsoneSerialization
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
            
            using (FileStream stream = new FileStream(path + @"\person.txt", FileMode.OpenOrCreate))
            {
                string str = JsonConvert.SerializeObject(persons);
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}

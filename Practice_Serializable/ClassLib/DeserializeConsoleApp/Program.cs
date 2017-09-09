using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DeserializeConsoleApp
{
    class Program
    {
        private static string path = @"C:\data";

        static void Main(string[] args)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(path + @"\listSerial.txt", FileMode.OpenOrCreate))
            {
                List<PC> newPCs = (List<PC>)formatter.Deserialize(stream);
                Console.WriteLine("Объект десериализован!");
                Console.WriteLine("Марка\t\tСерийный номер\t\tЦена");
                foreach (var i in newPCs)
                {
                    Console.WriteLine("\n" + i.Mark + "\t\t" + i.SerialNumber + "\t\t" + i.Price);
                }
                Console.ReadLine();
            }
        }
    }
}

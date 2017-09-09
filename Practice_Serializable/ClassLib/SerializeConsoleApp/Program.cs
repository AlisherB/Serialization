using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace SerializeConsoleApp
{
    class Program
    {
        private static string path = @"C:\data";

        static void Main(string[] args)
        {
            PC pc1 = new PC
            {
                Id = 0,
                Mark = "HP",
                SerialNumber = "123456789",
                Price = 80000
            };
            PC pc2 = new PC
            {
                Id = 1,
                Mark = "Samsung",
                SerialNumber = "987654321",
                Price = 75000
            };
            PC pc3 = new PC
            {
                Id = 2,
                Mark = "Dell",
                SerialNumber = "042345478",
                Price = 68000
            };
            PC pc4 = new PC
            {
                Id = 3,
                Mark = "Dellux",
                SerialNumber = "812315673",
                Price = 91000
            };
            List<PC> pcs = new List<PC>
            {
                pc1, pc2, pc3, pc4
            };

            BinaryFormatter formatter = new BinaryFormatter();
            if (Directory.Exists(path))
            {
                using (FileStream stream = new FileStream(path + @"\listSerial.txt", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(stream, pcs);
                    Console.WriteLine("Объект сериализован!");
                }
                Console.ReadLine();
            }
        }
    }
}

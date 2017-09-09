using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace HomeTask1
{
    class Program
    {
        private static string path = @"C:\data";

        static void Main(string[] args)
        {
            Book book1 = new Book
            {
                Name = "Анна Каренина",
                Author = "Л.Н.Толстой",
                Year = 1877,
                Price = 5000
            };
            Book book2 = new Book
            {
                Name = "Мертвые души",
                Author = "Н.В.Гоголь",
                Year = 1842,
                Price = 6500
            };
            List<Book> books = new List<Book>
            {
                book1, book2
            };
            BinaryFormatter formatter = new BinaryFormatter();
            if (Directory.Exists(path))
            {
                using (FileStream stream = new FileStream(path + @"\books.bin", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(stream, books);
                }
                using (FileStream stream = new FileStream(path + @"\books.bin", FileMode.Open))
                {
                    List<Book> newPCs = (List<Book>)formatter.Deserialize(stream);
                    Console.WriteLine("Объект десериализован!");
                    foreach(var i in newPCs)
                    {
                        Console.WriteLine();
                        Console.WriteLine(i.Name);
                        Console.WriteLine(i.Author);
                        Console.WriteLine(i.Year);
                        Console.WriteLine(i.Price);
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1
{
    [Serializable]
    public class Book
    {
        private string name;
        private int price;
        private string author;
        private int year;

        public string Name { get { return name; } set { name = value; } }
        public string Author { get { return author; } set { author = value; } }
        public int Price { get { return price; } set { price = value; } }
        public int Year { get { return year; } set { year = value; } }
    }
}

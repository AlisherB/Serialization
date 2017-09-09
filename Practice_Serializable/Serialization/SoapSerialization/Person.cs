using System;

namespace SoapSerialization
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Telephone { get; set; }
        public int Year { get; set; }
    }
}

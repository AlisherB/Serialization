using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    [Serializable]
    public class PC
    {
        //■	3–4 поля (марка, серийный номер и т.д
        [NonSerialized]
        private int? id;
        private string mark;
        private string serialNumber;
        private int price;
        //■	свойства (к каждому полю),  
        public int? Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Mark
        {
            get
            {
                return mark;
            }
            set
            {
                mark = value;
            }
        } 

        public string SerialNumber
        {
            get
            {
                return serialNumber;
            }
            set
            {
                serialNumber = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        //■	конструкторы (по умолчанию, с параметрами),  
        public PC()
        {
            id = 0;
            mark = null;
            serialNumber = null;
            price = 0;
        }
        public PC(string mark, string serialNumber, int price)
        {
            Id = id;
            Mark = mark;
            SerialNumber = serialNumber;
            Price = price;
        }
        //■	методы, моделирующие функционирование ПЭВМ (включение/выключение, перегрузку). 
        public int OnOffPC(bool onoff)
        {
            if (onoff)
                return 1;
            else
                return 0;
        }
    }
}

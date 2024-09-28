using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented.Glencore
{
    internal class Book
    {
        public int Bno {get;set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public override string ToString()
        {
            return $"Bno: {Bno} Name: {Name} Price; {Price}";
        }
    }
}

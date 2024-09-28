using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented.Glencore
{
    internal class Person
    {

        private int sno;
        private string? name;
        private string? city;//instance variables

        public Person() { } //constructor
        public Person(int sno, string name, string city)
        {
            this.sno = sno;
            this.name = name;
            this.city = city;
        }//overloaded constructor
        public void Show() {
            Console.WriteLine($"Sno: {sno} Name: {name} City: {city}");
        }
        public void SetPerson(int sno, string name, string city) { //sno,name,city -> local variables
          this.sno = sno;
          this.name = name;
          this.city = city;
        }
    }
}

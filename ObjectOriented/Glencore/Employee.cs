using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented.Glencore
{
    internal class Employee
    { 
        public int Eno {  get; set; }
        public string Name { get; set; }
        
        public double Salary { get; set; }

        public string Department { get; set; }

        public override string ToString()
        {
            return $"Eno: {Eno} Name:{Name} Salary:{Salary}";
        }
    }
}

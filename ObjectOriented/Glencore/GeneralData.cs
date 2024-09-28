using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Generics
//One class designed to work for any type
namespace ObjectOriented.Glencore
{
    internal class GeneralData<T>
    {
       private T info;

       public  T Info { get { return info; } set { this.info = value; }}

        public override string ToString()
        {
            return $"Info is: {info}";

        }
    }
}

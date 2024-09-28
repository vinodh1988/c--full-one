using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented.Glencore
{
    internal class Store
    {
        private string name;

        public string Name { 
            get {
                //logic    
                return name; 
            } 
            set {
                //logic
                value=value.ToUpper();
                name = value;
            } 
        }

        public void Show() {
            Console.WriteLine($"Name: :{name}");
        }
        
    }
}

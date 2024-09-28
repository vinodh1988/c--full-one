using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented.Glencore
{
    internal class Computer
    {

        private int cno;
        private string? brand;
        private string? ram;
        private string? cpu;
        private string? disksize; //disksize nullable

        public Computer(int cno = -1, string brand = "nobrand", string ram = "noram", string cpu = "nocpu", string disksize = "nosize")
        { 
           this.cno= cno;
           this.brand= brand;
           this.ram= ram;
           this.cpu= cpu;
           this.disksize= disksize;
        }

        public void Show() {
            Console.WriteLine($"cno:{cno} brand:{brand}  ram:{ram} cpu:{cpu} disksize:{disksize}");
        }

        public override string ToString()
        {
            return $"cno:{cno} brand:{brand}  ram:{ram} cpu:{cpu} disksize:{disksize}";
        }
    }
}

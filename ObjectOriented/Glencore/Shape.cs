using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ObjectOriented.Glencore
{
    internal class Shape
    {
        protected int noOfSides;
        protected string name;

        public Shape(int noOfSides = 0, string name="NoName") { 
            this.noOfSides = noOfSides;
            this.name = name;
        }
      virtual public void Show() {
            Console.WriteLine($"noofSides:{noOfSides} name: {name}");
        }

    }

    internal class Rectangle : Shape
    {
        private int length;
        private int breadth;

        public Rectangle(int noOfSides,String name,int length, int breadth) : base(noOfSides,name) {
            this.length = length;
            this.breadth = breadth;
        }
       override public void Show()
        {
            base.Show();
            Console.WriteLine($"Length:{length} Breadth: {breadth}");
        }

    }

    internal class Square : Shape
    {
        private int side;

        public Square(int noOfSides, String name, int side) : base(noOfSides, name)
        {
            this.side = side;
           
        }
        override public void Show()
        {
            base.Show();
            Console.WriteLine($"side: {side}");
        }

    }
}

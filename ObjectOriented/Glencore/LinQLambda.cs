using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented.Glencore
{
    internal class LinQLambda
    {
        public static void ListDemo1() {
            List<int> intlist = 
                [34, 3536, 645, 45, 45, 46, 46, 7, 7, 43, 324, 3451, 2, 432, 56, 346, 64];

            List<int> square =intlist.Select(x => x * x).ToList();
            List<int> result=intlist.Where(i => i % 2 == 0).ToList();
            Console.WriteLine("\n Square");
            foreach (int x in square)
                Console.Write(x + " ");
            Console.WriteLine("\n Even");
            foreach (int x in result)
                Console.Write(x + " ");

            Console.WriteLine("\n Printing");
            intlist.ForEach(x => Console.Write(x + "->"));
        }

        public static void ListDemo2()
        {
            string[] names = ["Irwin", "Ish", "John", "Ricky", "King", "Roger", "Jason", "Jade"];

            Console.WriteLine("Filtered Names");

            names.Where(x => x.StartsWith("J") || x.StartsWith("R"))
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}

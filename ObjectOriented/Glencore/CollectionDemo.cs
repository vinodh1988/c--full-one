using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented.Glencore
{
    internal class CollectionDemo
    {
        public static void StackDemo()
        {
            Stack s = new Stack(); //non generic
            s.Push(1);
            s.Push("Rahul");
            s.Push(new Book() { Bno = 1, Name = "Good Very Good", Price = 34.34 });
            try
            {
                while (true)
                    Console.WriteLine(s.Pop());
                //Exception: Runtime will throw Exception
            }
            catch (System.InvalidOperationException e)
            {
                Console.WriteLine("Attempting pop when no more elements exist");
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Some Excpetion" + e.Message);
            }

        }

        public static void StackDemo2()
        {
            Stack s = new Stack(); //non generic
            s.Push(1);
            s.Push("Rahul");
            s.Push(new Book() { Bno = 1, Name = "Good Very Good", Price = 34.34 });

            foreach (object o in s)
            {
                Console.WriteLine(o);
            }
        }


        public static void StackDemo3()
        {
            Stack<string> s = new Stack<string>(); // generic
            s.Push("Store");
            s.Push("Rahul");
            s.Push("Jack");

            foreach (string o in s)
            {
                Console.WriteLine(o);
            }
        }

        public static void ListDemo()
        {
            List<String> names = new List<String>();
            names.Add("Lokesh");
            names.Add("Akash");
            names.Add("Vikas");
            names.Add("Jay");
            names.Add(null);
            names.Add("Vikas");
            ;
            Console.WriteLine(names);
            Console.WriteLine(names.ElementAtOrDefault(3));

            foreach (string o in names)
            { Console.WriteLine(o); }
            names.Insert(3, "Rohan");
            Console.WriteLine("---------------------------------------");
            foreach (string o in names)
            { Console.WriteLine(o); }



        }

        public static void ListDemo2()
        {
            List<int> list = [34, 34, 35, 5, 34, 235, 5, 6, 35, 534, 34, 5, 35, 6, 345, 445, 45, 4646];
            List<string> names = ["Roger", "Gandhi", "Vikram", "Naresh", "Joseph", "Lenin", "Naveen"];

            var numbers = from num in list
                          select num;

            foreach (int i in numbers)
                Console.Write(i + " ");

            Console.WriteLine();

            numbers = from num in list
                      where num > 100 && num < 1000
                      select num;

            foreach (int i in numbers)
                Console.Write(i + " ");

            Console.WriteLine();
            var selectNames = from name in names
                              where name.StartsWith("N") || name.EndsWith("n")
                              select name;
            foreach (string i in selectNames)
                Console.Write(i + " ");


        }

        public static void ListDemo3()
        {
            List<Book> books = [
                new Book() { Bno=1, Name="Read it or throw it", Price=456.90},
                new Book() { Bno=2, Name="Dont read chapter 9", Price=156.90},
                new Book() { Bno=3, Name="Eat Well", Price=889.90},
                new Book() { Bno=4, Name="Real World", Price=1956.90},
                new Book() { Bno=5, Name="Strong vs Weak", Price=348.90},
                new Book() { Bno=6, Name="Dosa Batter", Price=1889.90},
                new Book() { Bno=7, Name="Mango seed", Price=546.90},
                ];

            var result = from book in books
                         where book.Price >= 500 && book.Price <= 1000
                         select (book.Name,book.Price);
                     //  select new {BookName =book.Name , BookPrice = book.Price}
            foreach (var book in result)
            {
                Console.WriteLine(book.Name, book.Price);
                Console.WriteLine(book.GetType().Name);
            }
        }

        public static void ListDemo4()
        {
            List<Book> books = [
              new Book() { Bno=1, Name="Read it or throw it", Price=456.90},
                new Book() { Bno=2, Name="Dont read chapter 9", Price=156.90},
                new Book() { Bno=3, Name="Eat Well", Price=889.90},
                new Book() { Bno=4, Name="Real World", Price=1956.90},
                new Book() { Bno=5, Name="Strong vs Weak", Price=348.90},
                new Book() { Bno=6, Name="Dosa Batter", Price=1889.90},
                new Book() { Bno=7, Name="Mango seed", Price=546.90},
                ];

            var result = from book in books
                         orderby book.Price descending
                         select book;

            foreach (var book in result)
            {
                Console.WriteLine(book);
            }
        }


        public static void ListDemo5() {
            List<Employee> elist = [
                   new Employee() { Eno=1, Name="Rajeev", Salary=15000, Department="Marketing"},
                   new Employee() { Eno=2, Name="Mahesh", Salary=78000, Department="Research"},
                   new Employee() { Eno=3, Name="Rakesh", Salary=19000, Department="Marketing"},
                   new Employee() { Eno=4, Name="Christopher", Salary=55000, Department="Marketing"},
                   new Employee() { Eno=5, Name="Lokesh", Salary=78000, Department="Finance"},
                   new Employee() { Eno=6, Name="Vignesh", Salary=45000, Department="Research"},
                   new Employee() { Eno=7, Name="Yuvraj", Salary=15000, Department="Finance"},
                   new Employee() { Eno=8, Name="Ganesh", Salary=25000, Department="Finance"},
                   new Employee() { Eno=9, Name="Naresh", Salary=35000, Department="Research"},
                ];
            var emps = from emp in elist
                       group emp by emp.Department into result
                       select result;

            foreach (var x in emps) { 
                Console.WriteLine(x.Key+"  ");
                Console.WriteLine("----------------------");
                foreach (Employee e in x)
                    Console.WriteLine(e);
            }

            
        }

        public static void HashSetDemo() {
            List<string> names = ["Rakesh","Graeme","Ajay","Vinay","Rahul","Rahul","Ajay","Jason",
               "Babu","Pater","Vikas","Rakesh"];

            HashSet<string> hnames=names.ToHashSet();

            foreach (var x in hnames)
                Console.Write(x + " ");
        }

        public static void DictionaryDemo()
        {
            Dictionary<string, string[]> teams = new Dictionary<string, string[]>();

            teams.Add("Development", new string[] {"Lohith","Ganesh","Rajan" });
            teams.Add("Testing", new string[] { "Mickey", "Johny", "Tom" });
            teams.Add("Operations", new string[] { "Christo", "Sam", "Kiran" });
            /*
            foreach (string x in teams["Development"]) { 
               Console.WriteLine($"{x}");*/

            foreach (string x in teams.Keys)
            {
                Console.WriteLine(x);
                Console.WriteLine("____________________________________");
                foreach (string i in teams[x])
                    Console.WriteLine($"{i}");
            }
            
           


        }

    }
}
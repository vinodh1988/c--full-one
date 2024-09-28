// See https://aka.ms/new-console-template for more information
using ObjectOriented.Glencore;
using System.Security.Cryptography;


DatabaseApplication.PrintPersonTable();
/*
List<Book> books=FileProcessing.ReadBooksFromFile("books.json");

books.ForEach(book => Console.WriteLine(book));
*/
/*

List<Book> books = [
  new Book() { Bno=1, Name="Read it or throw it", Price=456.90},
                new Book() { Bno=2, Name="Dont read chapter 9", Price=156.90},
                new Book() { Bno=3, Name="Eat Well", Price=889.90},
                new Book() { Bno=4, Name="Real World", Price=1956.90},
                new Book() { Bno=5, Name="Strong vs Weak", Price=348.90},
                new Book() { Bno=6, Name="Dosa Batter", Price=1889.90},
                new Book() { Bno=7, Name="Mango seed", Price=546.90},
                ];

FileProcessing.SerializeFile("books.json", books);
*/
/*
Console.WriteLine("Enter file content and type exit in a new line to exit");
string input = "";
while (true) {
   
    string? x=Console.ReadLine();
    if (x == "exit")
        break;
    input += x;
    input += "\n";

}
FileProcessing.WriteFile("sample.txt", input);

*/
//LinQLambda.ListDemo2();
//CollectionDemo.DictionaryDemo();
/*
GeneralData<string> stringx=new GeneralData<string>();
GeneralData<int> intx=new GeneralData<int>();
GeneralData<double> doublex=new GeneralData<double>();
GeneralData<Book> bookx=new GeneralData<Book>();
GeneralData<Computer> computerx=new GeneralData<Computer>();
stringx.Info = " String information";
intx.Info = 803403;
doublex.Info = 34434.34;
bookx.Info = new Book() { 
Bno =1, Name ="Good Book",Price=242
};
computerx.Info = new Computer(1,"Toshiba","4 GB","I7","512GB");


Console.WriteLine(stringx);
Console.WriteLine(intx);
Console.WriteLine(doublex);
Console.WriteLine(bookx);
Console.WriteLine(computerx);
*/
/*
Book[] books = {
    new Book(){ Bno=1,Name="Read this one",Price=234},
    new Book(){ Bno=2,Name="Page no 5", Price=250 },
    new Book(){ Bno=3,Name="Buy me", Price=900 }
};

foreach (Book book in books)
{
    Console.WriteLine(book); // book.toString();
}

*/
/*
Store s = new Store();

s.Name = "Raj"; // set {name= "Raj"}
Console.WriteLine(s.Name); // get {return name}
s.Show();

Store s1 = new Store() { Name = "Rajesh" };
s1.Show();*/
/*
Computer c = new Computer();
Computer c1 = new Computer(2);
Computer c3= new Computer(3,"Lenovo");
Computer c4 = new Computer(4, "Lenovo", disksize: "128 GB");
Computer c5 = new Computer(5, "Dell", "4gb", "intel i7", "1 TB");

c.Show();
c1.Show();
c3.Show();
c4.Show();
c5.Show();
*/
/*

using ObjectOriented.Glencore;

Person p=new Person();
p.Show();
Person p1 = new Person(1, "Ravi", "Chennai");
p1.Show();
p.SetPerson(2, "Rohan", "Mumba");
p.Show();
p1.Show();
*/
/*
Console.WriteLine("Hello, World!");

Person p = new Person();
//Type ref = Object
p.Show();
p.SetPerson(2, "Lokesh", "Mumbai");
p.Show();
Person p2 = new Person();
p2.Show();*/

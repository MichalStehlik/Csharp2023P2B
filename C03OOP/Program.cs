// See https://aka.ms/new-console-template for more information
using C03OOP;

Book pp = new Book("Pán prstenů");
//Console.WriteLine(pp.name);
Console.WriteLine(pp.GetName());
pp.SetName("Společenstvo prstenů");
Console.WriteLine(pp.GetName());

Book tt = new Book();
Console.WriteLine(tt.GetName());
Console.WriteLine(tt.GetTitle());

Book[] books = new Book[2];
books[0] = pp;
books[1] = tt;
foreach(var b in books)
{
    Console.WriteLine(b.GetName());
}
/*
string[] names =  new string[2];
string[] authors = new string[2];
authors[0] = "JRR";
authors[1] = "JRR";
*/
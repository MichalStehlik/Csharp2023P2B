// See https://aka.ms/new-console-template for more information
using C08Interface;

Book bab = new Book("Babička","Ahoj babičko a Barunko.");
Book lotr = new Book("Pán prstenů", "Jeden prsten vládne všem, jeden jim všem káže.");
Reader tonda = new Reader("Toník");
Console.WriteLine(tonda.Read(bab));
Newspaper blesk = new Newspaper();
Console.WriteLine(tonda.Read(blesk));
Console.WriteLine(bab.CompareTo(lotr)); // bab.CompareTo(lotr);
// == - IEquitable
// > - IComparable
// foreach - IEnumerable
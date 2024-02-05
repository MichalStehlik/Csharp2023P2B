// See https://aka.ms/new-console-template for more information
using C15Extension;
using System.Linq;

List<int> ints = new List<int> { 1, 2, 3, 7, 12, 89, 1, 9, 3 };
BetterList ints2 = new BetterList { 1, 2, 3, 7, 12, 89, 1, 9, 3 };
List<string> names = new List<string> { "Adéla", "Bořivoj", "Ctimír", "David", "Evžen"};
//Console.WriteLine(ListExtensions.OddCount(ints));
Console.WriteLine(ints.OddCount());
Console.WriteLine(ints.GreaterThen(10));
Console.WriteLine(ints.ItemsCount());
Console.WriteLine(names.ItemsCount());
Console.WriteLine("");
foreach (int i in ints.Odd())
{
    Console.WriteLine(i);
}
foreach (string i in names.LongerThen(5))
{
    Console.WriteLine(i);
}
foreach (string i in names.Where(x => x.Length > 5))
{
    Console.WriteLine(i);
}
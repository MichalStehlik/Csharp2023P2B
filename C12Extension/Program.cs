// See https://aka.ms/new-console-template for more information
using C12Extension;
using System.Linq;

var del = new Delegates(7,1);
Console.WriteLine(del.Do(del.Addition));
Console.WriteLine(del.Do(del.Subtraction));
Console.WriteLine(del.Do(del.Multiplication));
Console.WriteLine(del.Do(del.Division));
Console.WriteLine(del.Do(ReverseSubtraction));
Console.WriteLine(del.Do(delegate (float x, float y) { return x * x * y; }));
Console.WriteLine(del.Do((x, y) => { return x * x * y; }));
Console.WriteLine(del.Do((x, y) => ( x * x * y )));
Console.WriteLine();

List<int> floats = new List<int> { 1,10,3,4,40,6,7,8,2,1 };
foreach(var x in floats.Where(y => y > 16))
{
    Console.WriteLine(x);
}
foreach (var x in floats.OrderBy(y => y))
{
    Console.WriteLine(x);
}
Console.WriteLine();
foreach (var x in floats
    .Where(y => (y % 2 == 0))
    .OrderByDescending(y => y))
{
    Console.WriteLine(x);
}

float ReverseSubtraction(float a, float b) { return b - a; }
// See https://aka.ms/new-console-template for more information
// enum
using System.Collections.Immutable;

Gender my = Gender.Male;
Console.WriteLine((int)my);
// array
int[] numbers1 = new int[10]; // 0,0,0,0,...
int[] numbers2 = new int[10] {0,1,2,3,4,5,6,7,8,9};
for(int i = 0; i < numbers1.Count(); i++)
{
    Console.WriteLine("+ " + numbers1[i] + " +");
}
numbers2[3] = 100;
foreach(int x in numbers2)
{
    Console.WriteLine("- " + x + " -");
}
// numbers2[20] = 1; // IndexOutOfRangeException
Console.WriteLine(numbers2.Count()); // počet prvků
Array.Sort(numbers2);
foreach (int x in numbers2)
{
    Console.Write(x + ",");
}
Array.Reverse(numbers2);
foreach (int x in numbers2)
{
    Console.Write(x + ",");
}
Console.WriteLine(numbers2.Contains(6));
Console.WriteLine(Array.IndexOf(numbers2,6));
Console.WriteLine(Array.MaxLength);
Console.WriteLine(numbers2.Rank);

// vicerozměrná pole
int[,] map = new int[3, 2] { {1, 2}, { 3, 4}, { 5, 6} };
Console.WriteLine(map[0,0]);
Console.WriteLine(map.Rank);
map[1, 1] = 100;
for(int i = 0; i < map.GetLength(0); i++)
{
    for (int j = 0; j < map.GetLength(1); j++)
    {
        Console.Write(map[i,j] + ",");
    }
    Console.WriteLine();
}
foreach (int x in map)
{
    Console.Write(x + ",");
}
Console.WriteLine();
enum Gender 
{
    Unknown = 0,
    Male = 1,
    Female = 2,
    Other = 3
}

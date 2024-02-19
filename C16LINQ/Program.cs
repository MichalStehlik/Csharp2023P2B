// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
List<Human> humans = new List<Human> {
    new Human { Firstname = "Alois", Lastname="Antl", Title = "Mgr."},
    new Human { Firstname = "Beáta", Lastname="Blažejová",Title = "Ing."},
    new Human { Firstname = "Cyril", Lastname="Cvach", Title = "Admiral"},
    new Human { Firstname = "Diana", Lastname="Drahá", Title = "Mgr."},
    new Human { Firstname = "Evžen", Lastname="Evil", Title = "Admiral"}
};

foreach (Human human in humans)
{
    Console.WriteLine(human);
}

// podmínka
foreach (Human human in humans.Where(x => x.Firstname.StartsWith("C")))
{
    Console.WriteLine(human);
}

// řazení
foreach (Human human in humans.OrderBy(x => x.Lastname))
{
    Console.WriteLine(human);
}

// filtr
foreach (Human human in humans.Where(x => x.Firstname.StartsWith("C")))
{
    Console.WriteLine(human);
}

// řazení
foreach (Human human in humans.OrderByDescending(x => x.Title))
{
    Console.WriteLine(human);
}

foreach (var gr in humans.GroupBy(x => x.Title))
{
    Console.WriteLine(gr.Key + ":" + gr.Count());
}

// přetypování
foreach (var gr in humans.Select(x => new HumanName { Lastname = x.Lastname, Age = 16}))
{
    Console.WriteLine(gr.Lastname + " / " + gr.Age);
}

// kombinace
foreach (var h in humans.Where(x => x.Lastname.Contains("a")).OrderBy(x => x.Firstname))
{
    Console.WriteLine(h);
}

class Human
{
    public string Firstname { get; set; } = string.Empty;
    public string Lastname { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public override string ToString()
    {
        return Title + " " + Firstname + " " + Lastname;
    }
}

class HumanName
{
    public string Lastname { get; set; }
    public int Age { get; set; }

}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<Human> humans = new List<Human> {
    new Human { Firstname = "Alois", Lastname="Antl"},
    new Human { Firstname = "Beáta", Lastname="Blažejová"},
    new Human { Firstname = "Cyril", Lastname="Cvach"},
    new Human { Firstname = "Diana", Lastname="Drahá"},
    new Human { Firstname = "Evžen", Lastname="Evil"}
};

foreach (Human human in humans)
{
    Console.WriteLine(human);
}

class Human
{
    public string Firstname { get; set; } = string.Empty;
    public string Lastname { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;

    publi
}
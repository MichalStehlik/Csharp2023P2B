using C07Abstract;
using System.Net.Http.Headers;

Medium[] myMedia = new Medium[]
{
    new Book { Title = "Meč osudu", Author = "Andrzej Sapkowski", PagesCount = 300},
    new Audiobook { Title = "1984", Author = "George Orwell", Length = 200.2, PagesCount = 100},
    new Movie { Title = "Dune", Length = 180, FileName = "dune.mkv"},
    new Song { Title = "Victory", Interpret = "Thomas Bergersen", Length = 3.5}
};
myMedia[2].Title = "Oppenheimer";
foreach (var x in myMedia)
{
    Console.WriteLine(x.Title);
}
// var x = new Medium { Title = "AAAAA"};
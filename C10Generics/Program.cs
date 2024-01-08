using C10Generics;

var a = new IntStore(10);
a.Add(1);
Console.WriteLine(a.Value);
var b = new DoubleStore(10);
b.Add(1);
Console.WriteLine(b.Value);
var c = new StringStore("Ahoj");
c.Add(" světe.");
Console.WriteLine(c.Value);

var d = new Store<int>(20); // IntStore - vygeneruje za nás
Console.WriteLine(d.Value);
var e = new Store<int>(20);
Console.WriteLine(e.Value);
Console.WriteLine(d.Equals(e));

// ----

var x = new List<int>();
x.Add(1);
x.Add(2);
Console.WriteLine(x.Count);

var y = new List<double>();
x.Add(1);
x.Add(2);
Console.WriteLine(x.Count);
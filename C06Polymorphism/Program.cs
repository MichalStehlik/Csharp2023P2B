// See https://aka.ms/new-console-template for more information

using C06Polymorphism;

Animal x = new Animal();
Console.WriteLine(x.MakeSound());
Console.WriteLine(x);
Dog alik = new Dog();
Console.WriteLine(alik.MakeSound());
Console.WriteLine(alik.MakeHappySound());
Console.WriteLine(alik);
Animal bruno = new Dog(); // chová jako Dog
Console.WriteLine(bruno.MakeSound());
//Console.WriteLine(bruno.MakeHappySound());
Animal cvalda = new Cat(); // chová se jako Animal
Console.WriteLine(cvalda.MakeSound());
Console.WriteLine(cvalda);
Cat dave = new Cat();
Console.WriteLine(dave.MakeSound());
Console.WriteLine(dave);
Console.WriteLine("----");
Animal[] zoo = new Animal[] { x, alik, bruno, cvalda, dave};
foreach (Animal z in zoo)
{
    Console.WriteLine(z + ": " + z.MakeSound());
}
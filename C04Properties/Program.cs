// See https://aka.ms/new-console-template for more information
using C04Properties;

Human adam = new Human("Adam","Vomáčka");
adam.SetFirstname("Zoltán");
//adam.firstname = "Zoltán";
adam.Firstname = "Zoltán";
adam.Firstname = "Adolf";
Console.WriteLine(adam.Firstname);
Student blahoslav = new Student("Blahoslav","Bohatý","P2B");
Console.WriteLine(blahoslav.Firstname);

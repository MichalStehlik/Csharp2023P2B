using System.Collections;

int[] pole = new int[] { 1,2};
Student tonik = new Student { Name = "Antonín"};
// negenerická
ArrayList al = new ArrayList(); // object
al.Add(pole);
al.Add("Ahoj");
al.Add(true);
al.Add(tonik);
foreach (var i in al)
{
    if (i is Student && (i is not null))
    {
        Console.WriteLine((i as Student)!.Name);
    }
}
// generické
// List
List<Student> students = new List<Student>();
students.Add(tonik);
//students.Add(4);
students.Add(new Student { Name = "Květoslav"});
students.Add(new Student { Name = "Radovan" });
students.Add(new Student { Name = "Dalibor" });
students.Add(new Student { Name = "Slavomír" });
students.Add(new Student { Name = "Judita" });
foreach (var i in students)
{
    Console.WriteLine(i.Name);
}
students.Remove(tonik);
students.RemoveAt(2);
students.Insert(3,tonik);
Console.WriteLine(students.Count);
foreach (var i in students)
{
    Console.WriteLine(i.Name);
}
students.Sort(); // in-place
students.Reverse();
foreach (var i in students)
{
    Console.WriteLine(i.Name);
}
students[3].Name = "Ctirad";
Console.WriteLine(students[3].Name);
var x = students;
x[1] = new Student { Name = "Xaver" };
foreach (var i in students)
{
    Console.WriteLine(i.Name);
}

List<List<Student>> classes = new List<List<Student>>();
classes.Add(students);
classes.Add(new List<Student> { tonik });
foreach (var i in classes)
{
    foreach (var j in i)
    Console.WriteLine(j.Name);
}
// dictionary
Dictionary<string, Student> st = new Dictionary<string, Student>();
st.Add("ton",tonik);
st.Add("rad", new Student { Name = "Radek"});
Console.WriteLine(st["ton"].Name);

Dictionary<string, string> slovnicek = new Dictionary<string, string>();
slovnicek.Add("kočka","cat");
slovnicek.Add("pes","dog");
foreach(var i in slovnicek)
{
    Console.WriteLine(i.Key + " -> " + i.Value);
}
st.Remove("rad");
//st.Clear();
Console.WriteLine(st.Count);


class Student : IComparable<Student>, IEquatable<Student>
{
    public string Name { get; set; }

    public int CompareTo(Student? other)
    {
        return this.Name.CompareTo(other!.Name);
    }

    public bool Equals(Student? other)
    {
        return this.Name.Equals(other!.Name);
    }
}
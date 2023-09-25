// See https://aka.ms/new-console-template for more information
var succ = true;
if (!succ) Console.WriteLine("Yess"); // Operator!(a) -- unární
float a = 1 + 1; // Operator+(a,b) -- dualni
Console.WriteLine(a == 1 ? "Jedna" : "Nejedna"); // Operator?:(a,b,c) -- ternární
Console.WriteLine(a);
a = 2 * a + 1 % 3 - 7 + (1 + a);
a += 4; // a = a + 4
var x = 2 | 4;
var y = a == 2 || a == 4;
var z1 = 4 - 2;
var z2 = 2 - 4;
Dato q;
Dato r = new Dato();
q = r ?? new Dato();
Console.WriteLine(q!.Value);

// -------

int[] g = new int[] { 1,2,3,4};
int[] h = g; // reference, obě proměnné odkazují na stejnou paměť
g[0] = 100;
foreach(var e in h)
{
    Console.WriteLine(e); // 100,2,3,4
}

static int? Addition(int? a, int? b) // čistá
{
    /*
    if ( a is null || b is null)
    {
        return null;
    }
    else
    {
        return a + b;
    }
    */
    if (a is null || b is null)
    {
        return null;
    }
    return a + b;
}

static string Combine(string a) // není čistá
{
    var aa = Console.ReadLine();
    return a + aa;
}

/*
static int[] Roots1(int a, int b, int c)
{

}

static int[] Roots2(int a, int b, int c, out int x1, out int x2)
{

}

static int[] Roots3(int a, int b, int c, ref int x1, ref int x2)
{

}
*/



class Dato
{
    public int Value { get; set; }
}

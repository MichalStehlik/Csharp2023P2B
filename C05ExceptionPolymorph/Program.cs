using C05ExceptionPolymorph;

int a = 10;
int b = 0;
int c = 0;
try
{
    // potenciálně chybové kody, uživatelský vstup
    // čtení souborů, databází, přístup k hardware
    c = a / b;
    Console.WriteLine("Something");
}
catch (DivideByZeroException ex)
{
    // jen v případě chyby
    Console.WriteLine("Dělení nulou: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Neznámá chyba: " + ex.Message);
}
finally
{
    // proběhne vždy
    // uzavření spojení, odpojení souboru
    Console.WriteLine("Konex chráněného kódu");
}
Console.WriteLine(c);
// TryParse()
MyRectangle? x = null;
try
{
    x = new MyRectangle(0);
}
catch (RectangleException ex)
{
    Console.WriteLine(ex.Message);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine("Nesmyslná hodnota");
}
catch
{
    Console.WriteLine("Neznámá chyba");
}
Console.WriteLine((x == null) ? "NULL" : "Set");
// See https://aka.ms/new-console-template for more information
using System.Globalization;

DateTime n = DateTime.Now;
Console.WriteLine(n);
DateTime n1 = new DateTime(2000,10,2,1,0,0);
Console.WriteLine(n1);
DateTime nu = DateTime.UtcNow;
Console.WriteLine(nu);
DateTime n2 = new DateTime();
Console.WriteLine(n2);
DateTime n3 = n2.AddTicks(1000000000);
Console.WriteLine(n3);
DateTime n4 = n.AddDays(1);
Console.WriteLine(n4);
DateTime nEnd = new DateTime(2024,6,30,9,0,0);
Console.WriteLine(nEnd);
TimeSpan ts = nEnd - n;
Console.WriteLine(ts);
Console.WriteLine(ts.TotalSeconds);
Console.WriteLine(ts.TotalMinutes);
Console.WriteLine(n.IsDaylightSavingTime());
Console.WriteLine(DateTime.IsLeapYear(2024));
Console.WriteLine(DateTime.DaysInMonth(2024,3));
Console.WriteLine(n.ToShortDateString());
Console.WriteLine(n.ToLongDateString());
Console.WriteLine(n.ToString("d", CultureInfo.GetCultureInfo("en-US")));

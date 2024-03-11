// See https://aka.ms/new-console-template for more information
// Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BurzaFirem2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False

using C17LINQDB.Data;

var db = new AppDbContext();

Console.WriteLine(db.Database);
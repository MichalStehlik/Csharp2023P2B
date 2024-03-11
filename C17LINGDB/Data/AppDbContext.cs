using C17LINQDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C17LINQDB.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        private string _connectionString;

        public AppDbContext(): base()
        {
            _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BurzaFirem2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionString);
            optionsBuilder.LogTo(Console.WriteLine, new[] {
                RelationalEventId.CommandExecuted, RelationalEventId.CommandExecuted,
            });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        // Add-Migration Init
    }
}

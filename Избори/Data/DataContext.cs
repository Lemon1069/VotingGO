using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DataContext:DbContext
    {
        public DataContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server =(localdb)\\MSSQLLocalDB;Database=voting;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Candidate> Candidates { get; set; }
    }
}

using F1ResultsAssistant.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1ResultsAssistant.Db
{
    public class F1DbContext : DbContext
    {
        public DbSet<Constructor> Constructors { get; set; }
        public DbSet<ConstructorStanding> ConstructorStandings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=F1Db.db");
        }
    }
}

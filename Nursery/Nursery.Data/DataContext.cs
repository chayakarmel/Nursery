using Microsoft.EntityFrameworkCore;
using Nursery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Data
{
    public class DataContext:DbContext
    {

        public DbSet<Baby> Babies { get; set; }

        public DbSet<Nurse> Nurses { get; set; }

        public DbSet<Turn> Turns { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=sample_db;Trusted_Connection=True");
        }




    }
}

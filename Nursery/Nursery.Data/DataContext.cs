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


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)//mssqllocaldb;Database=my_db");
        }

        //public List<Baby> Babies { get; set; }

        //public DataContext()
        //{
        //    Babies=new List<Baby>{
        //        new Baby {Id= 1,Name= "Name",Age= 1 }
        //    };
           
        //}
        //public Baby AddABaby(Baby baby)
        //{
        //    //try 
        //    //{	        
        //    Babies.Add(new Baby { Id=+1,Name=baby.Name,Age=baby.Age});
        //    return baby;
        //    // }
        //    //catch (Exception)
        //    // {
        //    //	return "can't add";
        //    //  }

        //}
    }
}

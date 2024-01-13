using Nursery.Core.Models;
using Nursery.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Data.Repositories
{
    public class BabyRepository: IBabyRepository
    {
        private readonly DataContext _context;

        public BabyRepository(DataContext context)
        {
               _context = context;
        }

        public List<Baby> GetList()
        {
            return _context.Babies.ToList();
        }


        public Baby GetOneBaby(int id)
        {
            //return _context.Babies.Find(e => e.Id == id);
            return _context.Babies.Find(id);
        }
        
        public Baby AddBaby(Baby baby)
        {
           // _context.Babies.Add(new Baby { Name = baby.Name, BirthYear = baby.BirthYear,Email=baby.Email });
           _context.Babies.Add(baby);
            _context.SaveChanges();
            return baby;
        }
        public Baby PutBaby(int id,Baby baby)
        {
            //Baby temp = _context.Babies.Find(e => e.Id == id);
            // temp.Id = baby.Id;
            //temp.Name = baby.Name;
            //temp.BirthYear = baby.BirthYear;
            // temp.Email=baby.Email;
            //return baby;
            var temp = GetOneBaby(id);
              temp.Name = baby.Name;
              temp.BirthYear = baby.BirthYear;
              temp.Email=baby.Email;
            _context.SaveChanges();
            return temp;
        }

        public void DeleteBaby(int id)
        {
            //Baby temp = _context.Babies.Find(e => e.Id == id);
            //_context.Babies.Remove(temp);
            var baby=GetOneBaby(id);
            _context.Babies.Remove(baby);
            _context.SaveChanges();
        }
    }
}

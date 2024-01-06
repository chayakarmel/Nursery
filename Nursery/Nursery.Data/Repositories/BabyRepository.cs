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
            return _context.Babies.Find(e => e.Id == id);
        }
        
        public Baby AddBaby(Baby baby)
        {
            _context.Babies.Add(new Baby { Id =+1, Name = baby.Name, Age = baby.Age });
            return baby;
        }
        public Baby PutBaby(int id,Baby baby)
        {
            Baby temp = _context.Babies.Find(e => e.Id == id);
            temp.Id = baby.Id;
            temp.Name = baby.Name;
            temp.Age = baby.Age;
            return baby;
        }

        public void DeleteBaby(int id)
        {
            Baby temp = _context.Babies.Find(e => e.Id == id);
            _context.Babies.Remove(temp);
        }
    }
}

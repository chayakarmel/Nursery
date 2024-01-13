using Nursery.Core.Models;
using Nursery.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Data.Repositories
{
    public class NurseRepository : INurseRepository
    {
        private readonly DataContext _context;

        public NurseRepository(DataContext context)
        {
            _context = context;
        }

        public List<Nurse> GetList()
        {
            return _context.Nurses.ToList();
        }


        public Nurse GetOneNurse(int id)
        {

            return _context.Nurses.Find(id);
        }

        public Nurse AddNurse(Nurse nurse)
        {
            _context.Nurses.Add(nurse);
            _context.SaveChanges();
            return nurse;
        }
        public Nurse PutNurse(int id, Nurse nurse)
        {

            var temp = GetOneNurse(id);
            temp.Name = nurse.Name;
            temp.Email = nurse.Email;
            _context.SaveChanges();
            return temp;
        }

        public void DeleteNurse(int id)
        {
            var nurse = GetOneNurse(id);
            _context.Nurses.Remove(nurse);
            _context.SaveChanges();
        }
    }
}

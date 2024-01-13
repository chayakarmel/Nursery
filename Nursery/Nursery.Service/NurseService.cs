using Nursery.Core.Models;
using Nursery.Core.Repositories;
using Nursery.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Service
{
    
        public class NurseService : INurseService
        {
            private readonly INurseRepository _nurseRepository;

            public NurseService(INurseRepository nurseRepository)
            {
                _nurseRepository = nurseRepository;
            }
            public List<Nurse> GetAll()
            {
               
                return _nurseRepository.GetList();
            }

            public Nurse GetN(int id)
            {
                return _nurseRepository.GetOneNurse(id);
            }

            public Nurse AddN(Nurse nurse)
            {
                return _nurseRepository.AddNurse(nurse);
            }

            public Nurse PutN(int id, Nurse nurse)
            {
                return _nurseRepository.PutNurse(id, nurse);

            }

            public void DeleteN(int id)
            {
                _nurseRepository.DeleteNurse(id);
            }

        }
    
}

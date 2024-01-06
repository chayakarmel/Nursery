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
    public class BabyService: IBabyService
    {
        private readonly IBabyRepository _babyRepository;

        public BabyService(IBabyRepository babyRepository)
        {
                _babyRepository=babyRepository;
        }
         public List<Baby> GetAll()
        {
            return _babyRepository.GetList();
        }

        public Baby GetB(int id)
        {
            return _babyRepository.GetOneBaby(id);
        }

        public Baby AddB(Baby baby)
        {
            return _babyRepository.AddBaby(baby);
        }

        public Baby PutB(int id,Baby baby)
        {
            return _babyRepository.PutBaby(id, baby);

        }

        public void DeleteB(int id)
        {
            _babyRepository.DeleteBaby(id);
        }
        
    }
}

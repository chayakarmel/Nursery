using Nursery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Core.Repositories
{
    public interface INurseRepository
    {
        List<Nurse> GetList();

        Nurse GetOneNurse(int id);
        Nurse AddNurse(Nurse nurse);

        Nurse PutNurse(int id, Nurse nurse);

        void DeleteNurse(int id);
    }
}

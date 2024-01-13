using Nursery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Core.Services
{
    public interface INurseService
    {
        List<Nurse> GetAll();
        Nurse GetN(int id);
        Nurse AddN(Nurse nurse);
        Nurse PutN(int id, Nurse nurse);
        void DeleteN(int id);
    }
}

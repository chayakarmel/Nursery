using Nursery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Core.Services
{
    public interface IBabyService
    {
        List<Baby> GetAll();
        Baby GetB(int id);
        Baby AddB(Baby baby);
        Baby PutB(int id, Baby baby);
        void DeleteB(int id);
        
        
        
    }
}

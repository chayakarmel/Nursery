using Nursery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Core.Repositories
{
    public interface IBabyRepository
    {
        List<Baby> GetList();

        Baby GetOneBaby(int id);
        Baby AddBaby(Baby baby);

        Baby PutBaby(int id, Baby baby);

        void DeleteBaby(int id);
    }
}

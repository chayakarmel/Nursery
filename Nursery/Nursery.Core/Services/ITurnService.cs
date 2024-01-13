using Nursery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Core.Services
{
    public interface ITurnService
    {
        List<Turn> GetAll();
        Turn GetT(int id);
        Turn AddT(Turn turn);
        Turn PutT(int id, Turn turn);
        void DeleteT(int id);
    }
}

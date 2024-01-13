using Nursery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Core.Repositories
{
    public interface ITurnRepository
    {
        List<Turn> GetList();

        Turn GetOneTurn(int id);
        Turn AddTurn(Turn turn);

        Turn PutTurn(int id, Turn turn);

        void DeleteTurn(int id);
    }
}

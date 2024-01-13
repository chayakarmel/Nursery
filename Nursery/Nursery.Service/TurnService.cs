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
    public class TurnService : ITurnService
    {
        private readonly ITurnRepository _turnRepository;

        public TurnService(ITurnRepository turnRepository)
        {
            _turnRepository = turnRepository;
        }
        public List<Turn> GetAll()
        {

            return _turnRepository.GetList();
        }

        public Turn GetT(int id)
        {
            return _turnRepository.GetOneTurn(id);
        }

        public Turn AddT(Turn turn)
        {
            return _turnRepository.AddTurn(turn);
        }

        public Turn PutT(int id, Turn turn)
        {
            return _turnRepository.PutTurn(id, turn);

        }

        public void DeleteT(int id)
        {
            _turnRepository.DeleteTurn(id);
        }

    }
}

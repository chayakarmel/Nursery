using Nursery.Core.Models;
using Nursery.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Data.Repositories
{
    public class TurnRepository : ITurnRepository
    {
        private readonly DataContext _context;

        public TurnRepository(DataContext context)
        {
            _context = context;
        }

        public List<Turn> GetList()
        {
            return _context.Turns.ToList();
        }


        public Turn GetOneTurn(int id)
        {

            return _context.Turns.Find(id);
        }

        public Turn AddTurn(Turn turn)
        {
            _context.Turns.Add(turn);
            _context.SaveChanges();
            return turn;
        }
        public Turn PutTurn(int id, Turn turn)
        {

            var temp = GetOneTurn(id);
            temp.BeginningTime = turn.BeginningTime;
            temp.EndTime = turn.EndTime;
            _context.SaveChanges();
            return temp;
        }

        public void DeleteTurn(int id)
        {
            var turn = GetOneTurn(id);
            _context.Turns.Remove(turn);
            _context.SaveChanges();
        }
    }
}

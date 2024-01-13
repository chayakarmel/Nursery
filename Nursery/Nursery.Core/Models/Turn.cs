using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery.Core.Models
{
    public class Turn
    {
        public int Id { get; set; }

        public DateTime BeginningTime { get; set; }

        public DateTime EndTime { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milestone.Models
{
    public class CellModel
    {
        public int Id { get; set; }
        public int State { get; set; }

        public CellModel ()
        {

        }

        public CellModel (int id, int state)
        {
            Id = id;
            State = state;
        }
    }
}

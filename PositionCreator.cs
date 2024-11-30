using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonyClub
{
    public class PositionCreator : IPositionCreator
    {
        public Position GetDefaultPosition()
        {
            return new Position(0, 0);
        }
    }
}

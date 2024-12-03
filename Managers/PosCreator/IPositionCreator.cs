using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonyClub.Managers.PosCreator
{
    public interface IPositionCreator
    {
        public Position GetDefaultPosition();
    }
}

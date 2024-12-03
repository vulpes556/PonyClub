using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PonyClub.Enums;

namespace PonyClub.Ponies.Interfaces
{
    public interface IWalk
    {
        public string Walk(Direction direction);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonyClub.Managers
{
    public class RandomWrapper : IRandom
    {
        Random _random = new Random();

        public int Next(int max)
        {
            return _random.Next(max);
        }
    }
}

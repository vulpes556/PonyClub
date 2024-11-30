using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonyClub
{
    internal class Pegasus : Pony, IFly
    {
        public Pegasus(string name, Position position) : base(name, position)
        {
        }

        public string Fly(Position position)
        {
            if (Position.Equals(position))
            {
                throw new ArgumentException("Already there!");
            }
            this.Position = position;
            return ($"Pegasus {Name} flew to {position.ToString()}");
        }
    }
}

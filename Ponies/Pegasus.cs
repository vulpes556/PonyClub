using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PonyClub.Ponies;
using PonyClub.Ponies.Interfaces;


//+Pegasus: Can fly - jump to any coordinate

namespace PonyClub.Ponies
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
            Position = position;
            return $"Pegasus {Name} flew to {position.ToString()}";
        }
    }
}

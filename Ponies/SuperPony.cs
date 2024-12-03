using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PonyClub.Managers;
using PonyClub.Ponies;
using PonyClub.Ponies.Interfaces;



//+SuperPony : Can do fly and magic

namespace PonyClub.Ponies
{
    public class SuperPony : Pony, IFly, IDoMagic
    {
        private readonly IRandom _random;
        public SuperPony(string name, Position position, IRandom random) : base(name, position)
        {
            _random = random;
        }


        // how could i avoid this redundant code? this is the same as in the pegasus and unicorn classes

        public string DoMagic()
        {
            string[] appendables = new string[] { "*", "#", "&" };
            Name = Name + appendables[_random.Next(appendables.Length)];

            Level++;

            return $"Pony {Name} did some magic!";
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

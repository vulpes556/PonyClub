using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PonyClub.Managers;
using PonyClub.Ponies;
using PonyClub.Ponies.Interfaces;

//+Unicorn : Can do magic - experience level raised by one, name appends with * , # or &

namespace PonyClub.Ponies
{
    public class Unicorn : Pony, IDoMagic
    {
        private readonly IRandom _random;
        public Unicorn(string name, Position position, IRandom random) : base(name, position)
        {
            _random = random;
        }

        public string DoMagic()
        {
            string[] appendables = new string[] { "*", "#", "&" };
            Name = Name + appendables[_random.Next(appendables.Length)];

            Level++;

            return $"Pony {Name} did some magic!";
        }
    }
}

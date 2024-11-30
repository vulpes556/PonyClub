using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonyClub
{
    public class Unicorn : Pony, IDoMagic
    {
        public Unicorn(string name, Position position) : base(name, position)
        {
        }

        public string DoMagic()
        {
            Random random = new Random(); //not sure if this random should be created here or passed somehow

            string[] appendables = new string[] { "*", "#", "&" };
            Name = Name + appendables[random.Next(appendables.Length)];

            Level++;

            return $"Pony {Name} did some magic!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonyClub
{
    public class SuperPony : Pony, IFly, IDoMagic
    {
        public SuperPony(string name, Position position) : base(name, position)
        {
        }


        // how could i avoid this redundant code? this is the same as in the pegasus and unicorn classes

        public string DoMagic()
        {
            Random random = new Random(); //not sure if this random should be created here or passed somehow

            string[] appendables = new string[] { "*", "#", "&" };
            Name = Name + appendables[random.Next(appendables.Length)];

            Level++;

            return $"Pony {Name} did some magic!";
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

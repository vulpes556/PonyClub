using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonyClub
{
    public class PonyManager : IPonyManager
    {
        private readonly string[] _superponyNames = new string[] { "Meadow Breeze", "Pine Needle", "Ocean Splash", "Sunset Drift", "Thunder Hoof" };

        private readonly IPositionCreator _positionCreator;

        public List<Pony> Ponies { get; private set; }
        private IRandom _random;
        public PonyManager(IRandom random, IPositionCreator positionCreator)
        {
            _random = random;
            _positionCreator = positionCreator;
        }



        public SuperPony GetRandomSuperPony()
        {
            return new SuperPony(_superponyNames[_random.Next(_superponyNames.Length)], _positionCreator.GetDefaultPosition());
        }



        //not sure if i group the ponies based on their coordinates and return those groups where there are more then 1 pony, or just pass a coordinate and list all ponies there
        public string ListPoniesOnTheSamePosition()
        {
            throw new NotImplementedException();
        }


        // at the moment all ponies are given the same starter position, later this could be changed
        public Pony CreatePony(PonyType type, string name)
        {
            Position defaultPosition = _positionCreator.GetDefaultPosition();
            switch (type)
            {
                case PonyType.Normal:
                    {
                        Pony normal = new Pony(name, defaultPosition);
                        Ponies.Add(normal);
                        return normal;
                    }
                case PonyType.Pegasus:
                    {
                        Pegasus pegasus = new Pegasus(name, defaultPosition);
                        Ponies.Add(pegasus);
                        return pegasus;
                    }
                case PonyType.Unicorn:
                    {
                        Unicorn unicorn = new Unicorn(name, defaultPosition);
                        Ponies.Add(unicorn);
                        return unicorn;
                    }
                case PonyType.Super:
                    {
                        SuperPony super = new SuperPony(name, defaultPosition);
                        Ponies.Add(super);
                        return super;
                    }
                default:
                    {
                        throw new ArgumentException("Invalid pony type!");
                    }
            }
        }
    }
}

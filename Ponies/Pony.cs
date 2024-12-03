using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using PonyClub.Enums;
using PonyClub.Ponies.Interfaces;


//name, experience level, position

//● walk (1 unit in any direction :
//● NORTH, EAST, SOUTH, WEST)
//● can be renamed


namespace PonyClub.Ponies
{
    public class Pony : IWalk
    {
        public string Name { get; protected set; }
        public int Level { get; protected set; } = 0;

        public Position Position { get; protected set; }


        public Pony(string name, Position position) //should the position passed as param, or should i use default values? but then, is it this class's responsibility to create a new position?
        {
            Name = name;
            Position = position;
        }

        public string RenamePony(string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new ArgumentException("The new name cannot be empty!");
            }
            string origName = Name;
            Name = newName;
            return $"Pony {origName} is renamed to {newName}";
        }


        //at the moment there is no error handling for going out of bounds, since there is no map
        public string Walk(Direction direction)
        {
            int ponyPosY = Position.Row;
            int ponyPosX = Position.Col;


            switch (direction)
            {
                case Direction.North:
                    {
                        Position = new Position(ponyPosY - 1, ponyPosX); //should i create new positon objects, or should i modify the original? or should i have  a class thats porpuse is to create new positions, and pass that class in the constructor?
                        break;
                    }
                case Direction.South:
                    {
                        Position = new Position(ponyPosY + 1, ponyPosX);
                        break;
                    }
                case Direction.East:
                    {
                        Position = new Position(ponyPosY, ponyPosX + 1);
                        break;
                    }
                case Direction.West:
                    {
                        Position = new Position(ponyPosY, ponyPosX - 1);
                        break;
                    }
                default:
                    {
                        throw new ArgumentException("Invalid direction!");
                    }
            }
            return $"Pony walked to {Position.ToString()}";

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//username, registration date, ponies

//● every user registering in august gets a free SuperPony


namespace PonyClub
{
    public class User
    {
        public string Username { get; init; }
        public DateOnly RegDate { get; init; }
        public List<Pony> Ponies { get; set; } = new List<Pony>();

        public User(string username, DateOnly regDate)
        {
            Username = username;
            RegDate = regDate;
        }
    }
}

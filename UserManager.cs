using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonyClub
{
    public class UserManager : IUserManager
    {
        public List<User> Users = new List<User>();
        private readonly IPonyManager _ponyManager;

        public UserManager(IPonyManager ponyManager)
        {
            _ponyManager = ponyManager;
        }


        public string CreateNewUser(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) { throw new ArgumentException("Name cannot be empty!"); }

            DateOnly todaysDate = DateOnly.FromDateTime(DateTime.Now);
            const int AUGUST = 8;
            User newUser = new User(name, todaysDate);

            //check if the registration date is august, if so give the user a superPony!
            if (todaysDate.Month == AUGUST)
            {
                newUser.Ponies.Add(_ponyManager.GetRandomSuperPony());
            }

            Users.Add(newUser);

            return $"User with name: {name} was created sucessfully!";
        }

        public User GetUserWithHighestLVLPony()
        {
            // i have compacted these expressions into a single line, but i didnt delete it so others (myself :D ) could understand it better

            //var ponies = Users.SelectMany(user => user.Ponies);
            //var bestPony = ponies.OrderByDescending(pony => pony.Level).First();
            //var bestuser = Users.FirstOrDefault(user => user.Ponies.Contains(bestPony)).First();


            var userWithBestPony = Users.FirstOrDefault(user => user.Ponies.Contains(Users.SelectMany(user => user.Ponies).OrderByDescending(pony => pony.Level).First()));

            if (Users.Count == 0)
            {
                throw new InvalidOperationException("Not a single user has been created yet!");
            }
            else if (userWithBestPony == null)
            {
                throw new Exception("Not a single pony exist yet!");
            }

            return userWithBestPony;
        }

        public string AddPonyToUser(User user, PonyType type, string name)
        {
            try
            {
                var createdPony = _ponyManager.CreatePony(type, name);
                user.Ponies.Add(createdPony);
            }
            catch (Exception ex)
            {
                throw;
            }
            return $"Pony with name: {name} is created and added to user: {user.Username}";
        }

    }
}

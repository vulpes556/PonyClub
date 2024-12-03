using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PonyClub.Enums;

namespace PonyClub.Managers
{
    public interface IUserManager
    {
        public string CreateNewUser(string name);
        public User GetUserWithHighestLVLPony();

        public string AddPonyToUser(User user, PonyType type, string name);
    }
}

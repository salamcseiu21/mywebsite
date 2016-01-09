using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SnNetworkWebSite.DAL;
using SnNetworkWebSite.Models;

namespace SnNetworkWebSite.BLL
{
    public class UserManager
    {
        UserGateway userGateway=new UserGateway();

        public string Save(User anUser)
        {
            bool isUserExits = IsUserExits(anUser);
            if (isUserExits)
            {
                return "This email is already used by someone";
            }
            if (userGateway.Insert(anUser) > 0)
            {
                return "Registration sucessful";
            }
            return "Registration failed";
        }

        private bool IsUserExits(User anUser)
        {
            User user = userGateway.GetUserByEmail(anUser.Email);
            if (user != null)
            {
                return true;
            }
            return false;
        }

        public bool IsUserNameAndPasswordCorrect(string userName, string password)
        {
            return userGateway.IsUserNameAndPasswordCorrect(userName, password);
        }
    }
}
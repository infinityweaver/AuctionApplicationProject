using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionApplicationProject
{
    public abstract class User
    {
        public string Name { get; private set; }
        protected string Username { get; set; }
        protected string Password { get; set; }

        public User(string name, string username, string password)
        {
            this.Name = name;
            this.Username = username;
            this.Password = password;
        }

        public bool CanLogin(string username, string password)
        {
            return this.Username.Equals(username) && this.Password.Equals(password);
        }

        public bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            if(this.CanLogin(username, oldPassword))
            {
                this.Password = newPassword;
                return true;
            }
            return false;
        }
    }
}

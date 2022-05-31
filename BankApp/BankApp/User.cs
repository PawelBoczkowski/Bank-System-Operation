using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    public class User
    {
        public string Username = "";
        public string PasswordHash = "";
        public int Money = 200;

        public User(string username, string password)
        {
            this.Username = username;
            this.PasswordHash = password;
        }
        public User(string username, string password, int money)
        {
            this.Username = username;
            this.PasswordHash = password;
            this.Money = money;
        }
        public User()
        {

        }

        public override string ToString()
        {
            return $"User: {Username}";
        }
    }
}

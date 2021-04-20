using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApplication.Models
{
    public class UserModel
    {
        public int userId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string name { get; set; }

        public UserModel(int userId,string username,string password,string email,string name)
        {
            this.userId = userId;
            this.username = username;
            this.password = password;
            this.email = email;
            this.name = name;
        }
        public class LoginCredentials
        {
            public string username;
            public string password;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.MVC
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public User() { }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}

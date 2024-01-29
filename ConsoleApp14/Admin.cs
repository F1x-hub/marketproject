using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Admin : User
    {
        public string Role { get; set; }
        public int AccessLevel { get; set; }

        public Admin(string username, string role, int accessLevel) : base(username)
        {
            Role = role;
            AccessLevel = accessLevel;
        }
    }
}

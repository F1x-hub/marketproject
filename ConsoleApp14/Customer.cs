using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Customer : User
    {
        public string Email { get; set; }
        public double Balance { get; set; }

        public Customer(string username, string email, double balance) : base(username)
        {
            Email = email;
            Balance = balance;
        }
    }
}

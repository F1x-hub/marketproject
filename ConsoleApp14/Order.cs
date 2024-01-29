using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Order 
    {
        public User User { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        

        public Order(User user, Product product, int quantity)
        {
            User = user;
            Product = product;
            Quantity = quantity;
            
        }

        public override string ToString()
        {
            return $" {User.Username} bought {Quantity} {Product.Name}(s) for a total of ${Product.Price * Quantity}";
        }
    }
}

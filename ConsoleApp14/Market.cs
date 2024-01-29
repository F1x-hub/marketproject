using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp14
{
    internal class Market
    {
        private List<Product> products = new List<Product>();
        private List<Order> orders = new List<Order>();
        private List<User> users = new List<User>();
        private List<Customer> customers = new List<Customer>();
        private List<Admin> admins = new List<Admin>();
        

        
        public void AllProduct()
        {
            products.Add(new Product(1, "CocaCola", "Drink", 2));
            products.Add(new Product(2, "Twix", "Chocolate", 1));
            products.Add(new Product(3, "Milk", "Drink", 4));
            products.Add(new Product(4, "Lays", "Chips", 5));

            users.Add(new Customer("user1", "user1@email.com", 100.0));
            users.Add(new Customer("user2", "user2@email.com", 50.0));
            admins.Add(new Admin("admin1", "Administrator", 5));
        }
        public void ViwProduct()
        {

            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
        }
        public void SearchProduct(string Name)
        {
            bool tr = false; 
            foreach(Product item in products)
            {
                if (item.Name.ToLower() == Name.ToLower())
                {
                    tr = true;
                    Console.WriteLine(item);
                }
            }
            if (tr == false) 
            {
                Console.WriteLine("Product Not Find");
            }
        }
        public void AddProduct()
        {
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Product Category: ");
            string category = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            double price = int.Parse(Console.ReadLine());

            int NewProductId = products.Count + 1;

            Product NewProduct = new Product(NewProductId, name, category, price);
            products.Add(NewProduct);
            Console.WriteLine("Product added successfully.");

        }
        public void UpdateProduct(int Id)
        {
            bool tr = false;
            foreach (Product item in products)
            {
                if (item.Id == Id)
                {
                    tr = true;
                    Console.WriteLine(item);
                    Console.Write("Enter Name: ");
                    item.Name = Console.ReadLine();

                    Console.Write("Enter Category: ");
                    item.Category = Console.ReadLine();

                    Console.Write("Enter Price: ");
                    item.Price = double.Parse(Console.ReadLine());

                    Console.WriteLine(item);
                }
            }
            if (tr == false)
            {
                Console.WriteLine("Product Not Find");
            }

        }
        public void DeleteProduct(int Id)
        {
            bool tr = false;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == Id)
                {
                    tr = true;
                    products.Remove(products[i]);
                    Console.WriteLine("Product Deleted successfully");
                }
            }
            if (tr == false)
            {
                Console.WriteLine("Product Not Find");
            }
        }
        public void ViewSoldProduct()
        {
            Console.WriteLine("\nSold Products:");
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }
        public void BuyProduct()
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            foreach (var item in users)
            {
                if (item is Customer customer && item.Username == username)
                {
                    ViwProduct();
                    Console.Write("Choose product By Id: ");
                    int id = int.Parse(Console.ReadLine());

                    Product selectedProduct = null;

                    for (int i = 0; i < products.Count; i++)
                    {
                        if (products[i].Id == id)
                        {
                            selectedProduct = products[i];
                            break;
                        }
                    }

                    if (selectedProduct != null)
                    {
                        Console.Write("Enter quantity: ");
                        int quantity = int.Parse(Console.ReadLine());

                        double totalCost = selectedProduct.Price * quantity;

                        if (customer.Balance >= totalCost)
                        {
                            customer.Balance -= totalCost;

                            Order order = new Order(customer, selectedProduct, quantity); 
                            orders.Add(order);

                            Console.WriteLine("Purchase successful. Order placed.");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient balance. Purchase failed.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Product not found.");
                    }
                }
            }
        }
        public void RegisterUser()
        {
            Console.Write("Enter a username for registration: ");
            string username = Console.ReadLine();

            bool usernameTaken = false;

            foreach (var user in users)
            {
                if (user.Username == username)
                {
                    usernameTaken = true;
                    break;
                }
            }

            if (usernameTaken)
            {
                Console.WriteLine("Username is already taken. Please choose another.");
            }
            else
            {
                Console.Write("Enter user email: ");
                string email = Console.ReadLine();

                Console.Write("Enter user balance: ");
                double balance = double.Parse(Console.ReadLine());

                users.Add(new Customer(username, email, balance));
                Console.WriteLine("User registered successfully.");
            }
        }
        public void RegisterAdmin()
        {
            Console.Write("Enter an admin username for registration: ");
            string username = Console.ReadLine();

            bool usernameTaken = false;
            foreach (var admin in admins)
            {
                if (admin.Username == username)
                {
                    usernameTaken = true;
                    break;
                }
            }
            if (usernameTaken)
            {
                Console.WriteLine("Username is already taken. Please choose another.");
            }
            else
            {
                Console.Write("Enter admin role: ");
                string role = Console.ReadLine();

                Console.Write("Enter admin access level: ");
                int accessLevel = int.Parse(Console.ReadLine());

                admins.Add(new Admin(username, role, accessLevel));
                Console.WriteLine("Admin registered successfully.");
            }
        }
        public void ViewRegisteredUsers()
        {
            Console.WriteLine("\nRegistered Users:");

            foreach (var user in users)
            {
                if (user is Customer customer)
                {
                    Console.WriteLine($"Customer: {customer.Username}, Email: {customer.Email}, Balance: {customer.Balance}");
                }
            }

            
            foreach (var admin in admins)
            {
                Console.WriteLine($"Admin: {admin.Username}, Role: {admin.Role}, Access Level: {admin.AccessLevel}");
            }
        }
    }
}

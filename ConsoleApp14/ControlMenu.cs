using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp14
{
    internal class ControlMenu
    {
        public void Menu(Market market)
        {
            int control = 0;
            while (control != 4) 
            {
                Console.WriteLine("1. Admin\n2. User\n3. Registration\n4. Exit");
                control = int.Parse(Console.ReadLine());

                if (control == 1)
                {
                    AdminMenu(market);
                }
                if (control == 2)
                {
                    UserMenu(market);
                }
                if(control == 3)
                {
                    Registration(market);
                }
            }
        }
        public void AdminMenu(Market market) 
        {
            

            int control = 0;
            while (control != 7)
            {
                Console.WriteLine("\nAdmin Menu");
                Console.WriteLine("1. View Products\n2. Search Products\n3. Add Product\n4. Edit Product\n5. Delete Product\n6. View Sold Products\n7. Back");
                control = int.Parse(Console.ReadLine());

                if (control == 1)
                {
                    market.ViwProduct();
                }
                if (control == 2)
                {
                    Console.Write("Shearch By Name: ");
                    market.SearchProduct(Console.ReadLine());
                }
                if(control == 3)
                {
                    market.AddProduct();
                }
                if (control == 4)
                {
                    Console.Write("Shearch By Id: ");
                    market.UpdateProduct(int.Parse(Console.ReadLine()));
                }
                if (control == 5)
                {
                    Console.Write("Delete By Id: ");
                    market.DeleteProduct(int.Parse(Console.ReadLine()));
                }
                if (control == 6)
                {
                    market.ViewSoldProduct();
                }
            }

        }
        public void UserMenu(Market market)
        {
            int control = 0;
            while (control != 4)
            {
                Console.WriteLine("\nUser Menu");
                Console.WriteLine("1. View Products\n2. Search Products\n3. Buy Product\n4. back");
                control = int.Parse(Console.ReadLine());

                if (control == 1)
                {
                    market.ViwProduct();
                }  
                if (control == 2)
                {
                    Console.Write("Shearch By Name: ");
                    market.SearchProduct(Console.ReadLine());
                }
                if (control == 3) 
                {
                    market.BuyProduct();
                }
            }
        }
        public void Registration(Market market)
        {

            int control = 0;
            while (control != 4)
            {
                Console.WriteLine("\nRegistration Menu");
                Console.WriteLine("1. User Registration\n2. Admin Registration\n3. View All Users\n4. back");
                control = int.Parse(Console.ReadLine());

                if (control == 1)
                {
                    market.RegisterUser();
                }
                if (control == 2)
                {
                    market.RegisterAdmin();
                }
                if (control == 3)
                {
                    market.ViewRegisteredUsers();
                }
            }
        }
    }
}

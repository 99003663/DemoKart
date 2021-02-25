using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    class Program
    {
        static List<Product> ProductList1 = new List<Product>(10);
        static List<Product> ProductList2 = new List<Product>(10);
        static List<Product> ProductList3 = new List<Product>(10);
        static List<Product> ProductList4 = new List<Product>(10);
        static List<Product> CartList = new List<Product>(10);

        static void Main(string[] args)
        {

            Product[] ProductObj = new Product[20];
            User UserObj = new User();
            int n;
            double TotalPrice = 0, TotalPrice1 = 0, TotalPrice2 = 0, TotalPrice3 = 0, TotalPrice4 = 0;
            double GrandTotal1 = 0, GrandTotal2 = 0;
            Console.WriteLine("Welcome ");
            Console.WriteLine("Enter User name");
            String UserName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            String Password = Console.ReadLine();
            int value = UserObj.Login(UserName, Password);
            for (int i = 0; i < 7; i++)
            {
                ProductObj[0] = new Product(1, "TV", 50, 7);
                ProductObj[1] = new Product(2, "AC", 70, 6);
                ProductObj[2] = new Product(3, "Phone", 1000, 7);
                ProductObj[3] = new Product(4, "Power Bank", 300, 6);
                ProductObj[4] = new Product(5, "Charger", 250, 7);
                ProductObj[5] = new Product(6, "Refrigerator", 10000, 4);
                ProductObj[6] = new Product(7, "earphones", 200, 7);
                ProductObj[7] = new Product(8, "Laptop", 20000, 5);
                ProductList1.Add(ProductObj[i]);
            }
            for (int i = 0; i < 7; i++)
            {
                ProductObj[0] = new Product(1, "Butter", 50, 5);
                ProductObj[1] = new Product(2, "Milk", 60, 2);
                ProductObj[2] = new Product(3, "Meat", 50, 5);
                ProductObj[3] = new Product(4, "Fish", 60, 2);
                ProductObj[4] = new Product(5, "Oil", 50, 5);
                ProductObj[5] = new Product(6, "Eggs", 60, 2);
                ProductObj[6] = new Product(7, "Bread", 50, 5);
                ProductObj[7] = new Product(8, "Fruits", 60, 2);

                ProductList2.Add(ProductObj[i]);
            }
            for (int i = 0; i < 7; i++)
            {
                ProductObj[0] = new Product(5, "Formal Shirt", 55, 6);
                ProductObj[1] = new Product(6, "Formal Shoes", 70, 4);
                ProductObj[2] = new Product(7, "T Shirts", 55, 6);
                ProductObj[3] = new Product(8, "Sports Shoes", 70, 4);
                ProductObj[4] = new Product(9, " Jeans", 55, 6);
                ProductObj[5] = new Product(10, "Suits", 2000, 4);
                ProductObj[6] = new Product(11, "Dresses", 500, 6);
                ProductObj[7] = new Product(12, "Skirts", 100, 4);

                ProductList3.Add(ProductObj[i]);
            }
            for (int i = 0; i < 2; i++)
            {
                ProductObj[0] = new Product(7, "Eyeliner", 60, 7);
                ProductObj[1] = new Product(8, "Perfumes", 40, 8);

                ProductList4.Add(ProductObj[i]);
            }

            if (value == 1)
            {

                do
                {
                    Console.WriteLine("1.Electronics\t2.Grocery\t3.Clothes\t4.Cosmetics");
                    int Choice = Convert.ToInt32(Console.ReadLine());
                    if (Choice == 1)
                    {

                        foreach (Product item in ProductList1)
                        {

                            Console.WriteLine("Product id : " + item.Id);
                            Console.WriteLine("Product Name : " + item.Name);
                            Console.WriteLine("Product Price : " + item.Price);
                            Console.WriteLine("Product Quantity : " + item.Quantity);
                            Console.WriteLine("\n");
                        }
                    }
                    else if (Choice == 2)
                    {

                        foreach (Product item in ProductList2)
                        {

                            Console.WriteLine("Product id : " + item.Id);
                            Console.WriteLine("Product Name : " + item.Name);
                            Console.WriteLine("Product Price : " + item.Price);
                            Console.WriteLine("Product Quantity : " + item.Quantity);
                            Console.WriteLine("\n");
                        }
                    }
                    else if (Choice == 3)
                    {

                        foreach (Product item in ProductList3)
                        {

                            Console.WriteLine("Product id : " + item.Id);
                            Console.WriteLine("Product Name : " + item.Name);
                            Console.WriteLine("Product Price : " + item.Price);
                            Console.WriteLine("Product Quantity : " + item.Quantity);
                            Console.WriteLine("\n");
                        }
                    }
                    else if (Choice == 4)
                    {

                        foreach (Product item in ProductList4)
                        {

                            Console.WriteLine("Product id : " + item.Id);
                            Console.WriteLine("Product Name : " + item.Name);
                            Console.WriteLine("Product Price : " + item.Price);
                            Console.WriteLine("Product Quantity : " + item.Quantity);
                            Console.WriteLine("\n");
                        }
                    }

                    else 
                    {
                        Console.WriteLine("wrong input");

                    }
                    Console.WriteLine("1.revisit\t2.Order");
                    n = Convert.ToInt32(Console.ReadLine());
                } while (n==1);
                Product ob = new Product();



                {

                    Console.WriteLine("Enter your user name");
                    string username = Console.ReadLine();

                    Console.WriteLine("Enter your address");
                    string address = Console.ReadLine();

                    Console.WriteLine("Enter your user id");
                    int userid = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter your mobile no");
                    int mobileno = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter your password");
                    int password = Convert.ToInt32(Console.ReadLine());

                    User obj = new User(username, address, userid, mobileno, password);
                    obj.display();
                }  
            }
        }

    }
}

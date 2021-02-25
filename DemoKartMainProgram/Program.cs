using ECommerceSite.DemoKartBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSite
{
    class Program
    {
        static List<Product> CartList = new List<Product>(20);

        static List<Product> ProductList = new List<Product>(20);
        public void Display(int id)
        {
            foreach (Product item in ProductList)
            {
                if (id == item.CObj.categoriesId)
                {
                    Console.WriteLine("Product id : " + item.productId + "\tProduct Name : " + item.productName + "\tProduct Price : " + item.price + "\tProduct Quantity : " + item.quantity + "\tCategory Id : " + item.CObj.categoriesId + "\tCategory Name : " + item.CObj.categories);
                }
            }
        }


        static void Main(string[] args)
        {
            Product[] ProductObj = new Product[20];
            for (int i = 0; i < 13; i++)
            {
                ProductObj[0] = new Product(1, "Iphone", 1000, 5, 1, "Electronics");
                ProductObj[1] = new Product(2, "mi 10", 1000, 2, 1, "Electronics");
                ProductObj[2] = new Product(3, "TV", 500, 10, 1, "Electronics");
                ProductObj[3] = new Product(4, "Watch", 100, 4, 3, "Clothing");
                ProductObj[4] = new Product(5, "Fan", 500, 4, 1, "Electronics");
                ProductObj[5] = new Product(6, "Saree", 500, 4, 3, "Clothing");
                ProductObj[6] = new Product(7, "Shirt", 500, 4, 3, "Clothing");
                ProductObj[7] = new Product(8, "Pant", 500, 4, 3, "Clothing");
                ProductObj[8] = new Product(9, "Skirt", 500, 4, 3, "Clothing");
                ProductObj[9] = new Product(10, "Eggs", 50, 4, 2, "Grocery");
                ProductObj[10] = new Product(11, "Milk", 90, 4, 2, "Grocery");
                ProductObj[11] = new Product(12, "Lipstick", 5000, 4, 4, "Cosmetics");
                ProductObj[12] = new Product(13, "eyeliner", 5000, 4, 4, "Cosmetics");

                ProductList.Add(ProductObj[i]);

            }

            Category CObj = new Category();
            Cart CartObj = new Cart();
            Program programObj = new Program();

            Order OrderObj = new ECommerceSite.Order();
            Payment paymentObj = new Payment();
            int num, num1, num2, num3, num4, id;
            double TotalPrice = 0, TotalPrice1 = 0, TotalPrice2 = 0, TotalPrice3 = 0, TotalPrice4 = 0;
            double GrandTotal1 = 0, GrandTotal2 = 0;
            User UserObj = new User();
            Console.WriteLine("Welcome to our website");
            Console.WriteLine("Enter The User Name");
            String UserName = Console.ReadLine();
            Console.WriteLine("Enter The Password");
            String Password = Console.ReadLine();
            int value = UserObj.Login(UserName, Password);
            try
            {

                if (value == 1)
                {
                    do
                    {
                        Console.WriteLine("1.Electronics\t2.Grocery\t3.Clothing\t4.Cosmetics");
                        int Choice = Convert.ToInt32(Console.ReadLine());
                        if (Choice == 1)
                        {
                            programObj.Display(Choice);
                            Console.WriteLine("1.Add To Cart\t2.Continue");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            if (num1 == 1)
                            {
                                Console.WriteLine("\nEnter the product ID of the product  you want to add  : ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nEnter The Quantity You Want");
                                int quant = Convert.ToInt32(Console.ReadLine());
                                foreach (Product item in ProductList)
                                {
                                    if (id == item.productId)
                                    {
                                        value = CartObj.AddToCart(quant);
                                        if (value == 1)
                                        {
                                            Console.WriteLine("Quantity Size Exceeded The Limit\n");
                                            break;
                                        }
                                        else
                                        {
                                            double TotalPric = CObj.CalculatePrice(Choice, item.price, quant);
                                            TotalPrice1 = TotalPrice1 + TotalPric;
                                            Product cust_cart = new Product(item.productId, item.productName, item.price, quant, item.CObj.categoriesId, item.CObj.categories);
                                            CartList.Add(cust_cart);
                                            Console.WriteLine("Add To cart Is Successfull\n");
                                        }

                                    }
                                }

                            }
                        }
                        if (Choice == 2)
                        {
                            programObj.Display(Choice);
                            Console.WriteLine("1.Add To Cart\t2.Continue");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            if (num1 == 1)
                            {
                                Console.WriteLine("\nEnter the product ID of the product you want to Add to Cart : ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nEnter the Quantity you want");
                                int quant = Convert.ToInt32(Console.ReadLine());
                                foreach (Product item in ProductList)
                                {
                                    if (id == item.productId)
                                    {
                                        value = CartObj.AddToCart(quant);
                                        if (value == 1)
                                        {
                                            Console.WriteLine("Quantity Size Exceeded The Limit\n");
                                            break;
                                        }
                                        else
                                        {
                                            double TotalPric = CObj.CalculatePrice(Choice, item.price, quant);
                                            TotalPrice1 = TotalPrice1 + TotalPric;
                                            Product cust_cart = new Product(item.productId, item.productName, item.price, quant, item.CObj.categoriesId, item.CObj.categories);
                                            CartList.Add(cust_cart);
                                            Console.WriteLine("Add To cart Is Successfull\n");
                                        }

                                    }
                                }

                            }
                        }
                        if (Choice == 3)
                        {
                            programObj.Display(Choice);
                            Console.WriteLine("1.Add To Cart\t2.Continue");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            if (num1 == 1)
                            {
                                Console.WriteLine("\nEnter ID's of Product You Want Add to Cart : ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nEnter How Many Quantity You Want");
                                int quant = Convert.ToInt32(Console.ReadLine());
                                foreach (Product item in ProductList)
                                {
                                    if (id == item.productId)
                                    {
                                        value = CartObj.AddToCart(quant);
                                        if (value == 1)
                                        {
                                            Console.WriteLine("Quantity Size Exceed The Limit\n");
                                            break;
                                        }
                                        else
                                        {
                                            double TotalPric = CObj.CalculatePrice(Choice, item.price, quant);
                                            TotalPrice1 = TotalPrice1 + TotalPric;
                                            Product cust_cart = new Product(item.productId, item.productName, item.price, quant, item.CObj.categoriesId, item.CObj.categories);
                                            CartList.Add(cust_cart);
                                            Console.WriteLine("Add To cart Is Successfull\n");
                                        }

                                    }
                                }

                            }
                        }
                        if (Choice == 4)
                        {
                            programObj.Display(Choice);
                            Console.WriteLine("1.Add To Cart\t2.Continue");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            if (num1 == 1)
                            {
                                Console.WriteLine("\nEnter ID's of Product You Want Add to Cart : ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nEnter How Many Quantity You Want");
                                int quant = Convert.ToInt32(Console.ReadLine());
                                foreach (Product item in ProductList)
                                {
                                    if (id == item.productId)
                                    {
                                        value = CartObj.AddToCart(quant);
                                        if (value == 1)
                                        {
                                            Console.WriteLine("Quantity Size Exceed The Limit\n");
                                            break;
                                        }
                                        else
                                        {
                                            double TotalPric = CObj.CalculatePrice(Choice, item.price, quant);
                                            TotalPrice1 = TotalPrice1 + TotalPric;
                                            Product cust_cart = new Product(item.productId, item.productName, item.price, quant, item.CObj.categoriesId, item.CObj.categories);
                                            CartList.Add(cust_cart);
                                            Console.WriteLine("Add To cart Is Successfull\n");
                                        }

                                    }
                                }

                            }
                        }
                        Console.WriteLine("1.Revisit\t2.Display Cart And Payment");
                        num = Convert.ToInt32(Console.ReadLine());
                    } while (num == 1);
                }
                foreach (Product item in CartList)
                {

                    Console.WriteLine("Product id : " + item.productId);
                    Console.WriteLine("Product Name : " + item.productName);
                    Console.WriteLine("Product Price : " + item.price);
                    Console.WriteLine("Product Quantity : " + item.quantity);
                    Console.WriteLine("Product Quantity : " + item.CObj.categoriesId);
                    Console.WriteLine("Product Quantity : " + item.CObj.categories);
                    Console.WriteLine("\n");
                }
                Console.WriteLine("1.Delete the cart List\t2.Order");
                num2 = Convert.ToInt32(Console.ReadLine());
                do
                {

                    if (num2 == 1)
                    {
                        Console.WriteLine("Enter The Product Id You Want To Delete");
                        int PI = Convert.ToInt32(Console.ReadLine());
                        foreach (Product item in CartList)
                        {
                            if (PI == item.productId)
                            {
                                CartList.Remove(item);
                                Console.WriteLine("Cart item " + PI + " Deleted");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Item is not available in Cart");
                                break;
                            }


                        }
                    }
                    else
                    {
                        break;
                    }

                    Console.WriteLine("1.Remove Another Cart\t2.Order");
                    num3 = Convert.ToInt32(Console.ReadLine());
                } while (num3 == 1);

                foreach (Product item in CartList)
                {
                    Console.WriteLine("Updated Cart List");
                    Console.WriteLine("Product id : " + item.productId);
                    Console.WriteLine("Product Name : " + item.productName);
                    Console.WriteLine("Product Price : " + item.price);
                    Console.WriteLine("Product Quantity : " + item.quantity);
                    Console.WriteLine("Product Quantity : " + item.CObj.categoriesId);
                    Console.WriteLine("Product Quantity : " + item.CObj.categories);
                    Console.WriteLine("\n");
                }

                Console.WriteLine("Enter Details To Complete Order");
                Console.WriteLine("Enter The First Name : ");
                OrderObj.FirstName = Console.ReadLine();
                Console.WriteLine("Enter  The Last Name : ");
                OrderObj.LastName = Console.ReadLine();
                Console.WriteLine("Enter The Mobile Number : ");
                OrderObj.mobileNo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter The Delivery Address : ");
                OrderObj.deliveryAddress = Console.ReadLine();
                Console.WriteLine("Enter Pincode : ");
                OrderObj.pinCode = Convert.ToInt32(Console.ReadLine());

                TotalPrice = TotalPrice1 + TotalPrice2 + TotalPrice3 + TotalPrice4;

                Console.WriteLine("Choose The Payment Method");
                Console.WriteLine("1.ByCash\t2.ByCard");
                num4 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Order  Placed ..................");
                Console.WriteLine("First Name : " + OrderObj.FirstName + "\nLast Name : " + OrderObj.LastName + "\nMobile Number : " + OrderObj.mobileNo + "\nDelivery Address : " + OrderObj.deliveryAddress + "\nPinCode : " + OrderObj.pinCode);
                if (num4 == 1)
                {
                    GrandTotal1 = paymentObj.CGSTTax(num4, TotalPrice);
                    Console.WriteLine("Central GST is : " + GrandTotal1);
                    GrandTotal2 = paymentObj.SGSTTax(num4, TotalPrice);
                    Console.WriteLine("State GST is : " + GrandTotal2);
                }
                else if (num4 == 2)
                {
                    double GrandTotal3 = paymentObj.CGSTTax(num4, TotalPrice);
                    Console.WriteLine("Central GST is : " + GrandTotal3);
                    double GrandTotal4 = paymentObj.SGSTTax(num4, TotalPrice);
                    Console.WriteLine("State GST is : " + GrandTotal4);
                }
                else
                {
                    Console.WriteLine("Wrong Choice");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Thank You For Visiting.....................................");
            }
        }
    }
}

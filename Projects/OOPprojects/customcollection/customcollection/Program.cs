

using customcollection.Store;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace customcollection
{
  
    internal class Program
    {
        public static List<StoreItem> storeitems = new List<StoreItem>();
        
        Stack<string> keys = new Stack<string>();
        static void Main(string[] args)
        {   //make items in store 
            storeitems.Add(new StoreItem("Milk", 30, 3));
            storeitems.Add(new StoreItem("Tiger", 15, 5));
            storeitems.Add(new StoreItem("SunTop", 12, 4));
            storeitems.Add(new StoreItem("HoHos", 10.5, 2));
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("----------------------------- Welcome To Memo's Super Market -------------------------------");
            Cart c1 = new Cart();
            while (true)
            {
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("1.Add Item To Cart");
                Console.WriteLine("2.Remove Item From Cart");
                Console.WriteLine("3.View Cart");
                Console.WriteLine("4.Checkout");
                Console.WriteLine("5.Undo");
                Console.WriteLine("6.Exit");
                Console.ForegroundColor = ConsoleColor.White;
                char choice =Console.ReadLine()[0];
                switch(choice)
                {
                    case '1':
                        c1.viewStoreItems();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Enter Item");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        string item = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Enter Quantity");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        int Q = int.Parse(Console.ReadLine());
                        c1.additem(item,Q);
                        break;
                    case '2':
                        //Remove
                        c1.viewcart();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Enter item");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        item = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        c1.remove(item);
                        break;
                    case '3':
                        //View
                        c1.viewcart();
                        break;
                    case '4':
                        //Checkout
                        c1.checkout();
                        break;
                    case '5':
                        //Undo
                        c1.undo();
                        break;
                    case '6':
                        //Exit
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Good Bye ..");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid Number .. Try Again ");
                        break;
                        
                }
            }
        }
    }
}

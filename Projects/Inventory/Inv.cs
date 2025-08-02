namespace Inventory
{
    internal class Program
    {
         const short ProductNum = 30;

        static string [,] Products = new string[ProductNum,3];

        static short cntP = 0;
        static void Main(string[] args)
        {
            //Inventory system 
            //Add Product - ID ,Name , Quantity , Price
            //update product
            //show products

            Console.WriteLine("----------------------------- Welcome To Inventory System -------------------------");
            
            while (true)
            {
                Console.WriteLine("1. Add Product ");
                Console.WriteLine("2. Update Price ");
                Console.WriteLine("3. Show Products ");
                Console.WriteLine("4. Exit ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        //Add product
                        Console.Write("Enter Product Name :");
                        string Pname= Console.ReadLine();
                        Console.Write("\nEnter Quantity :");
                        string PQuantity = Console.ReadLine();
                        Console.Write("\nEnter Price :");
                        string Price = Console.ReadLine();

                        AddProduct(Pname, PQuantity, Price);
                        Console.WriteLine("\nProduct Added Successfully .. ");
                        Console.WriteLine("---------------------------------");

                        break;

                    case "2":
                        //Update
                        Console.Write("Enter Your Product : ");
                        string item= Console.ReadLine();
                        Console.Write("\nEnter New Price : ");
                        string Q = Console.ReadLine();
                        UpdatePrice(item, Q);
                        Console.WriteLine("\n---------------------------------");
                        break;

                    case "3":
                        //Show
                        showProducts();
                        Console.WriteLine("---------------------------------");
                        break;

                    case "4":
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static void AddProduct(string Name , string Quantity , string Price )
        {   if (cntP > ProductNum)
            {
                Console.WriteLine("Inventory Full .. Can't Add Your Product ");
            }
            else
            {
                Products[cntP, 0] = Name;
                Products[cntP, 1] = Quantity;
                Products[cntP, 2] = Price;

                cntP++;

            }
        }

        static void showProducts()
        {
            if (cntP == 0)
            {
                Console.WriteLine("Inventory Is Empty .. ");

            }
            else
            {
                Console.WriteLine($"\tID  \t  | \tName  \t  | \tQuantity  \t  | \tPrice  ");
                for (int i = 0; i < cntP; i++)
                {
                    Console.WriteLine($"\t{i} \t  | \t{Products[i, 0]} \t   |  \t{Products[i, 1]} \t  | \t{Products[i, 2]}");

                }
            }
        }

        static void UpdatePrice(string P , string p2)
        {
            int flag = -1;
            for (int i = 0;i< cntP; i++)
            {
                if (P == Products[i, 0])
                {
                    flag = i;
                    break;
                }

            }
            if (flag != -1)
            {
                Products[flag, 2] = p2;
            }
            else
            {
                Console.WriteLine("Item Not Founded");
            }
        }
    }
}

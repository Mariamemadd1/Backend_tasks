using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using customcollection;

namespace customcollection.Store
{
    internal class Cart
    {
        Stack<string> Actions = new Stack<string>();
        List<StoreItem> CartItems = new List<StoreItem>();
        double checout=0;
        public bool additem(string item, int Q)
        {   
            
            foreach (var i in Program.storeitems)
            {
                if( i.Name== item)
                {
                    
                    Console.ForegroundColor = ConsoleColor.White;
                    if (i.Available(Q)) {
                        if (CartItems.Count == 0)
                        {
                            checout += (i.Price * Q);
                            i.Quantity -= Q;
                            CartItems.Add(new StoreItem(item, i.Price, Q));
                            Console.WriteLine($"{i.Name} Q: {Q} Added successfully");
                            Actions.Push($"{i.Name} Q: {Q} Added successfully");
                            return true;
                        }
                        else {
                            foreach (var i1 in CartItems)
                            {
                                if (i.Name == i1.Name)
                                {
                                    checout += (i.Price * Q);
                                    i.Quantity -= Q;
                                    i1.Quantity += Q;
                                    Console.WriteLine($" {i1.Name} Added successfully");
                                    Actions.Push($"{i1.Name} Q: {Q} Added successfully");
                                    return true;
                                }

                                else
                                {
                                    checout += (i.Price * Q);
                                    i.Quantity -= Q;
                                    CartItems.Add(new StoreItem(item, i.Price, Q));
                                    Console.WriteLine($"{i.Name} Added successfully");
                                    Actions.Push($"{i.Name} Q: {Q} Added successfully");
                                    return true;
                                }
                            }
                    } 
                }
                else
                {
                    Console.WriteLine($"{i.Name} out of stock"); 
                }  
               }
            }
            return false;

        }

        public void viewcart()
        {
            foreach (var item in CartItems)
            {
                Console.WriteLine($"item : {item.Name} , Price : {item.Price} , Quantity : {item.Quantity}");
            }
        }
        public void checkout()
        {
            viewcart();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total : {checout}");
        }

        public bool remove(string item)
        {
            if (CartItems.Count == 0)
            {
                Console.WriteLine("Cart Is Empty .. ");
                return false;
            }
            else
            {
                
                foreach (var i in CartItems)
                {
                    if (i.Name == item)
                    {
                        checout -= (i.Price * i.Quantity);
                        CartItems.Remove(i);
                        Console.WriteLine($"{i.Name} Removed Successfully .. ");
                        Actions.Push($"{i.Name} Removed Successfully .. ");
                        return true;
                    }
                }
                Console.WriteLine("Couldn't Find This Item .. ");
                return false;
            }
        }


        public void undo()
        {
            string LastAction=Actions.Pop();

            var s= LastAction.Split();
            if (LastAction.Contains("Added"))
            {
                remove(s[0]);
            }
            else
            {
                var x = int.Parse(s[2]);
                additem(s[1], x );
            }
        }

        public void viewStoreItems()
        {
            foreach (var x in Program.storeitems)
            {
                Console.WriteLine($"item : {x.Name} , Price : {x.Price} , Quantity : {x.Quantity}");
            }
           
        }
}
}

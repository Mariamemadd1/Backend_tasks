using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customcollection.Store
{
    internal class StoreItem
    {
        public string Name;
        public double Price;
        public int Quantity;
        public StoreItem(string name,double price,int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
        
        public bool Available(int o)
        {
            if (this.Quantity > 0 && o<= this.Quantity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}

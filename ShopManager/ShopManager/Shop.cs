using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShopManager
{
    public class Shop
    {
        string name, address, owner;
        Dictionary<long, ShopEntry> foodBar;

        public Shop(string name, string address, string owner) : this(name, address, owner, new Dictionary<long, ShopEntry>())
        {

        }

        public Shop(string name, string address, string owner, Dictionary<long, ShopEntry> foodBar)
        {
            this.name = name;
            this.address = address;
            this.owner = owner;
            this.foodBar = foodBar;
        }
        
        public string GetName()
        {
            return name;
        }
        
        public string GetAddress()
        {
            return address;
        }


        public string GetOwner()
        {
            return owner;

        }
        
        public bool IsAnyCertainFood(Type t)
        {
            foreach (KeyValuePair<long, ShopEntry> oneShopEntry in foodBar)
            {
                ShopEntry se = oneShopEntry.Value;
                if (t.IsInstanceOfType(se.GetF()) && se.GetQuantity() > 0)
                    return true;
            }
            return false;
        }

        public bool IsAnyMilk()
        {
            return IsAnyCertainFood(typeof(Milk));
        }

        public void BuyFood(Food f, int quantity)
        {
            ShopEntry s;

            s = foodBar[f.GetBarcode()];
            if (s != null)
            {
                s.DecrementQuantity(quantity);
            }
        }

        public Food RemoveFood(long barcode)
        {
            Food removableFood = foodBar[barcode].GetF();
            foodBar.Remove(barcode);
            return removableFood;
        }

        public void AddFood(Food f, int quantity, int price)
        {
            ShopEntry s;

            try
            {
                s = foodBar[f.GetBarcode()];
                s.IncrementQuantity(quantity);
            }
            catch (KeyNotFoundException)
            {
                s = new ShopEntry(f, quantity, price);
                foodBar.Add(f.GetBarcode(), s);
            }
        }

        public class ShopEntry
        {
            Food f;
            int quantity, price;

            public ShopEntry(Food f, int quantity, int price)
            {
                this.f = f;
                this.quantity = quantity;
                this.price = price;
            }

            public Food GetF()
            {
                return f;
            }

            public void SetF(Food f)
            {
                this.f = f;
            }

            public int GetQuantity()
            {
                return quantity;
            }

            void SetQuantity(int quantity)
            {
                this.quantity = quantity;
            }

            public void IncrementQuantity(int quantity)
            {
                this.quantity += quantity;
            }

            public void DecrementQuantity(int quantity)
            {
                this.quantity -= quantity;
            }

            int GetPrice()
            {
                return price;
            }

            void SetPrice(int price)
            {
                this.price = price;
            }
        }
    }
}

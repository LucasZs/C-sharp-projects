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
        Dictionary<long, ShopEntry> milkBar;

        public Shop(string name, string address, string owner) : this(name, address, owner, new Dictionary<long, ShopEntry>())
        {

        }

        public Shop(string name, string address, string owner, Dictionary<long, ShopEntry> milkBar)
        {
            this.name = name;
            this.address = address;
            this.owner = owner;
            this.milkBar = milkBar;
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

        public bool IsAnyMilk()
        {
            return milkBar.Count != 0;
        }

        public LonglifeMilk BuyMilk(long barcode)
        {
            LonglifeMilk removableMilk = milkBar[barcode].GetM();
            milkBar.Remove(barcode);
            return removableMilk;
        }

        public void AddMilk(LonglifeMilk m)
        {
            ShopEntry s;
            try
            {
                s = milkBar[m.GetBarcode()];
                s.IncrementQuantity(1);
            }
            catch (KeyNotFoundException)
            {
                s = new ShopEntry(m, 1, 200);
                milkBar.Add(m.GetBarcode(), s);
            }
        }

        public class ShopEntry
        {
            LonglifeMilk m;
            int quantity, price;

            public ShopEntry(LonglifeMilk m, int quantity, int price)
            {
                this.m = m;
                this.quantity = quantity;
                this.price = price;
            }

            public LonglifeMilk GetM()
            {
                return m;
            }

            public void SetM(LonglifeMilk m)
            {
                this.m = m;
            }

            int GetQuantity()
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

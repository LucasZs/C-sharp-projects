using System;
using System.Collections.Generic;
using ShopManager.Exceptions;


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

        public Dictionary<long, ShopEntry> GetFoodBar()
        {
            return foodBar;
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

        public void BuyFood(long barcode, int quantity)
        {
            if (!foodBar.ContainsKey(barcode))
            {
                throw new NonexistentWareException("Product with this barcode does not exists!");
            }

            ShopEntry s = (ShopEntry)foodBar[barcode];

            if (s.GetQuantity() - quantity <= 0)
            {
                throw new TooMuchDecrementionException("The quantity of this product is not enough to buy!");
            }
            
            s.DecrementQuantity(quantity);
        }

        public void RemoveFood(long barcode)
        {
            if (foodBar.ContainsKey(barcode))
            {
                foodBar.Remove(barcode);
            }
            else
            {
                throw new NonexistentWareException("Product with this barcode doesn't exists!");
            }
        }

        public void AddFood(long barcode, int quantity)
        {
            if (!foodBar.ContainsKey(barcode))
            {
                throw new NonexistentWareException("Product with this barcode doesn't exists!");
            }
            else {
                ShopEntry s = foodBar[barcode];
                s.IncrementQuantity(quantity);
            }
        }

        public void AddNewFood(Food f, int price, int quantity)
        {
            ShopEntry s = new ShopEntry(f, quantity, price);

            if (!foodBar.ContainsKey(f.GetBarcode()))
                {
                foodBar.Add(f.GetBarcode(), s);
                }
            else
            {
                throw new ArgumentException("The product with this specific barcode already exists!");
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

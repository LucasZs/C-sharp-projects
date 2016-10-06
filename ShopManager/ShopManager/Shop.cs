using System;
using System.Collections.Generic;
using ShopManager.Exceptions;
using System.Collections;

namespace ShopManager
{
    public class Shop : IShop
    {
        bool open = false;
        string name, address, owner;
        Dictionary<long, ShopEntry> wareBar;

        public Shop(string name, string address, string owner) : this(name, address, owner, new Dictionary<long, ShopEntry>())
        {

        }

        public Shop(string name, string address, string owner, Dictionary<long, ShopEntry> wareBar)
        {
            this.name = name;
            this.address = address;
            this.owner = owner;
            this.wareBar = wareBar;
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

        public void Opens()
        {
            open = true;
        }

        public void Closes()
        {
            open = false;
        }

        public Dictionary<long, ShopEntry> GetWareBar()
        {
            return wareBar;
        }
        
        public bool IsAnyCertainWare(Type t)
        {
            foreach (KeyValuePair<long, ShopEntry> oneShopEntry in wareBar)
            {
                ShopEntry se = oneShopEntry.Value;
                if (t.IsInstanceOfType(se.GetWare()) && se.GetQuantity() > 0)
                    return true;
            }
            return false;
        }

        public bool IsAnyMilk()
        {
            return IsAnyCertainWare(typeof(Milk));
        }

        public void BuyWare(long barcode, int quantity)
        {
            if (!open)
            {
                throw new ClosedException("The shop is closed.");
            }

            if (!wareBar.ContainsKey(barcode))
            {
                throw new NonexistentWareException("Product with this barcode does not exists!");
            }

            ShopEntry s = (ShopEntry) wareBar[barcode];

            if (s.GetQuantity() - quantity <= 0)
            {
                throw new TooMuchDecrementionException("The quantity of this product is not enough to buy!");
            }
            
            s.DecrementQuantity(quantity);
        }

        public void RemoveWare(long barcode)
        {
            if (wareBar.ContainsKey(barcode))
            {
                wareBar.Remove(barcode);
            }
            else
            {
                throw new NonexistentWareException("Product with this barcode doesn't exists!");
            }
        }

        public void AddWare(long barcode, int quantity)
        {
            if (!wareBar.ContainsKey(barcode))
            {
                throw new NonexistentWareException("Product with this barcode doesn't exists!");
            }
            else {
                ShopEntry s = wareBar[barcode];
                s.IncrementQuantity(quantity);
            }
        }

        public void AddNewWare(Ware ware, int price, int quantity)
        {
            ShopEntry s = new ShopEntry(ware, quantity, price);

            if (!wareBar.ContainsKey(ware.GetBarcode()))
                {
                wareBar.Add(ware.GetBarcode(), s);
                }
            else
            {
                throw new ArgumentException("The product with this specific barcode already exists!");
            }
        }

        public IEnumerator GetWares()
        {
            if (!open)
            {
                throw new ClosedException("The shop is closed.");
            }
            return new WareEnumerator(wareBar.Values.GetEnumerator());
        }
        
        public class ShopEntry
        {
            Ware ware;
            int quantity, price;

            public ShopEntry(Ware ware, int quantity, int price)
            {
                this.ware = ware;
                this.quantity = quantity;
                this.price = price;
            }

            public Ware GetWare()
            {
                return ware;
            }

            public void SetWare(Ware ware)
            {
                this.ware = ware;
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

            public override string ToString()
            {
                return
                    ware + 
                    "\nPrice: " + price + 
                    "\nQuantity: " + quantity;
            }
        }

        internal class WareEnumerator : IEnumerator
        {
            IEnumerator enumerator;

            internal WareEnumerator(IEnumerator enumerator)
            {
                this.enumerator = enumerator;
            }

            public bool MoveNext()
            {
                return enumerator.MoveNext();
            }

            public object Current
            {
                get
                {
                    try
                    {
                        ShopEntry shopEntry = (ShopEntry) enumerator.Current;
                        Ware ware = shopEntry.GetWare();
                        return ware;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException("The current position of enumerator is out of the collection!");
                    }
                }
            }

            public void Reset()
            {
                enumerator.Reset();
            }
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;


namespace ShopManager.Tests
{
    [TestClass()]
    public class ShopTests
    {
        [TestMethod()]
        public void GetNameTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> wareBar = new Dictionary<long, Shop.ShopEntry>();
            wareBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", wareBar);
            Assert.AreEqual("Little Shop of Horrors", sh.GetName());
        }

        [TestMethod()]
        public void GetAddressTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> wareBar = new Dictionary<long, Shop.ShopEntry>();
            wareBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", wareBar);
            Assert.AreEqual("Nowhere City, 6666, 10, Downing Str.", sh.GetAddress());
        }

        [TestMethod()]
        public void GetOwnerTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> wareBar = new Dictionary<long, Shop.ShopEntry>();
            wareBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", wareBar);
            Assert.AreEqual("Dr. Acula", sh.GetOwner());
        }

        [TestMethod()]
        public void IsAnyCertainWareTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> wareBar = new Dictionary<long, Shop.ShopEntry>();
            wareBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", wareBar);
            Assert.AreEqual(true, sh.IsAnyCertainWare(typeof(LonglifeMilk)));
        }

        [TestMethod()]
        public void IsAnyMilkTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> wareBar = new Dictionary<long, Shop.ShopEntry>();
            wareBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", wareBar);
            Assert.AreEqual(true, sh.IsAnyMilk());
        }

        [TestMethod()]
        public void BuyWareTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            sh.AddNewWare(newMilk, 200, 3);
            Dictionary<long, Shop.ShopEntry> foodBar = sh.GetWareBar();
            Shop.ShopEntry se = foodBar[newMilk.GetBarcode()];
            int quantity = se.GetQuantity();
            sh.BuyWare(newMilk.GetBarcode(), 1);
            Assert.AreEqual(quantity - 1, se.GetQuantity());
        }
        
        [TestMethod()]
        public void AddNewWareTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            sh.AddNewWare(newMilk, 200, 1);
            Dictionary<long, Shop.ShopEntry> wareBar = sh.GetWareBar();
            Shop.ShopEntry se = wareBar[newMilk.GetBarcode()];
            Assert.AreEqual(1, se.GetQuantity());
        }

        [TestMethod()]
        public void AddWareTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            sh.AddNewWare(newMilk, 200, 1);
            Dictionary<long, Shop.ShopEntry> foodBar = sh.GetWareBar();
            Shop.ShopEntry se = foodBar[newMilk.GetBarcode()];
            int quantity = se.GetQuantity();
            sh.AddWare(newMilk.GetBarcode(), 1);
            Assert.AreEqual(quantity + 1, se.GetQuantity());
        }

        [TestMethod()]
        public void RemoveWareTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            sh.AddNewWare(newMilk, 200, 1);
            sh.RemoveWare(820716);
            Dictionary<long, Shop.ShopEntry> wareBar = sh.GetWareBar();
            Assert.AreEqual(false, wareBar.ContainsKey(newMilk.GetBarcode()));
        }

        [TestMethod()]
        public void GetWaresTest()
        {
            LonglifeMilk milk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop shop = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            shop.AddNewWare(milk, 200, 1);
            Dictionary<long, Shop.ShopEntry> wareBar = shop.GetWareBar();
            Shop.ShopEntry se = wareBar[milk.GetBarcode()];
            IEnumerator shopEnum = shop.GetWares();
            Assert.IsTrue(shopEnum.MoveNext());
        }
    }
}
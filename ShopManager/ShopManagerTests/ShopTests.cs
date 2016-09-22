using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
            Dictionary<long, Shop.ShopEntry> foodBar = new Dictionary<long, Shop.ShopEntry>();
            foodBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", foodBar);
            Assert.AreEqual("Little Shop of Horrors", sh.GetName());
        }

        [TestMethod()]
        public void GetAddressTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> foodBar = new Dictionary<long, Shop.ShopEntry>();
            foodBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", foodBar);
            Assert.AreEqual("Nowhere City, 6666, 10, Downing Str.", sh.GetAddress());
        }

        [TestMethod()]
        public void GetOwnerTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> foodBar = new Dictionary<long, Shop.ShopEntry>();
            foodBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", foodBar);
            Assert.AreEqual("Dr. Acula", sh.GetOwner());
        }

        public void IsAnyCertainFoodTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> milkBar = new Dictionary<long, Shop.ShopEntry>();
            milkBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", milkBar);
            Assert.AreEqual(true, sh.IsAnyCertainFood(typeof(LonglifeMilk)));
        }

        [TestMethod()]
        public void IsAnyMilkTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> milkBar = new Dictionary<long, Shop.ShopEntry>();
            milkBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", milkBar);
            Assert.AreEqual(true, sh.IsAnyMilk());
        }

        [TestMethod()]
        public void BuyFoodTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            sh.AddNewFood(newMilk, 200, 3);
            Dictionary<long, Shop.ShopEntry> foodBar = sh.GetFoodBar();
            Shop.ShopEntry se = foodBar[newMilk.GetBarcode()];
            int quantity = se.GetQuantity();
            sh.BuyFood(newMilk.GetBarcode(), 1);
            Assert.AreEqual(quantity - 1, se.GetQuantity());
        }

        [TestMethod()]
        public void AddNewFoodTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            sh.AddNewFood(newMilk, 200, 1);
            Dictionary<long, Shop.ShopEntry> foodBar = sh.GetFoodBar();
            Shop.ShopEntry se = foodBar[newMilk.GetBarcode()];
            Assert.AreEqual(1, se.GetQuantity());
        }

        [TestMethod()]
        public void AddFoodTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            sh.AddNewFood(newMilk, 200, 1);
            Dictionary<long, Shop.ShopEntry> foodBar = sh.GetFoodBar();
            Shop.ShopEntry se = foodBar[newMilk.GetBarcode()];
            int quantity = se.GetQuantity();
            sh.AddFood(newMilk.GetBarcode(), 1);
            Assert.AreEqual(quantity + 1, se.GetQuantity());
        }

        [TestMethod()]
        public void RemoveFoodTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            sh.AddNewFood(newMilk, 200, 1);
            sh.RemoveFood(820716);
            Dictionary<long, Shop.ShopEntry> foodBar = sh.GetFoodBar();
            Assert.AreEqual(false, foodBar.ContainsKey(newMilk.GetBarcode()));
        }
    }
}
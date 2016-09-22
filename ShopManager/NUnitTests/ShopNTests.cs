using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ShopManager.Exceptions;

namespace ShopManager.NUnitTests
{
    [TestFixture]
    class ShopNTests
    {
        [Test]
        public void GetNameTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> foodBar = new Dictionary<long, Shop.ShopEntry>();
            foodBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", foodBar);
            Assert.AreEqual("Little Shop of Horrors", sh.GetName());
        }

        [Test]
        public void GetAddressTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> foodBar = new Dictionary<long, Shop.ShopEntry>();
            foodBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", foodBar);
            Assert.AreEqual("Nowhere City, 6666, 10, Downing Str.", sh.GetAddress());
        }

        [Test]
        public void GetOwnerTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> foodBar = new Dictionary<long, Shop.ShopEntry>();
            foodBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", foodBar);
            Assert.AreEqual("Dr. Acula", sh.GetOwner());
        }

        [Test]
        public void IsAnyCertainFoodTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> milkBar = new Dictionary<long, Shop.ShopEntry>();
            milkBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", milkBar);
            Assert.AreEqual(true, sh.IsAnyCertainFood(typeof(LonglifeMilk)));
        }

        [Test]
        public void IsAnyMilkTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> foodBar = new Dictionary<long, Shop.ShopEntry>();
            foodBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", foodBar);
            Assert.AreEqual(true, sh.IsAnyMilk());
        }

        [Test]
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

        [Test]
        public void BuyFoodTooMuchDecrementionExceptionTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            sh.AddNewFood(newMilk, 200, 3);
            Dictionary<long, Shop.ShopEntry> foodBar = sh.GetFoodBar();
            Shop.ShopEntry se = foodBar[newMilk.GetBarcode()];
            Assert.Throws<TooMuchDecrementionException>(() => sh.BuyFood(newMilk.GetBarcode(), 4), "The quantity of this product is not enough to buy!");
        }

        [Test]
        public void BuyFoodThrowsNonexistentWareExceptionTest()
        { 
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop.ShopEntry shopEntry = new Shop.ShopEntry(newMilk, 20, 200);
            Dictionary<long, Shop.ShopEntry> foodBar = new Dictionary<long, Shop.ShopEntry>();
            foodBar.Add(newMilk.GetBarcode(), shopEntry);
            Shop shop = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", foodBar);
            Assert.Throws<NonexistentWareException>(() => shop.BuyFood(821456607, 3), "Product with this barcode does not exists!");
        }

        [Test]
        public void AddNewFoodTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            sh.AddNewFood(newMilk, 200, 1);
            Dictionary<long, Shop.ShopEntry> foodBar = sh.GetFoodBar();
            Shop.ShopEntry se = foodBar[newMilk.GetBarcode()];
            Assert.AreEqual(1, se.GetQuantity());
        }

        [Test]
        public void AddNewFoodTestThrowsArgumentException()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            sh.AddNewFood(newMilk, 200, 1);
            Dictionary<long, Shop.ShopEntry> foodBar = sh.GetFoodBar();
            Shop.ShopEntry se = foodBar[newMilk.GetBarcode()];
            Assert.Throws<ArgumentException>(() => sh.AddNewFood(newMilk, 200, 1), "The product with this specific barcode already exists!");
        }

        [Test]
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

        [Test]
        public void AddFoodThrowsNonexistentWareExceptionTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop.ShopEntry shopEntry = new Shop.ShopEntry(newMilk, 20, 200);
            Dictionary<long, Shop.ShopEntry> foodBar = new Dictionary<long, Shop.ShopEntry>();
            foodBar.Add(newMilk.GetBarcode(), shopEntry);
            Shop shop = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", foodBar);
            Assert.Throws<NonexistentWareException>(() => shop.AddFood(821456607, 3), "Product with this barcode does not exists!");
        }

        [Test]
        public void RemoveFoodTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            sh.AddNewFood(newMilk, 200, 1);
            sh.RemoveFood(820716);
            Dictionary<long, Shop.ShopEntry> foodBar = sh.GetFoodBar();
            Assert.AreEqual(false, foodBar.ContainsKey(newMilk.GetBarcode()));
        }

        [Test]
        public void RemoveFoodThrowsNonexistentWareTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            sh.AddNewFood(newMilk, 200, 1);
            Dictionary<long, Shop.ShopEntry> foodBar = sh.GetFoodBar();
            Assert.Throws<NonexistentWareException>(() => sh.RemoveFood(821456607), "Product with this barcode does not exists!"); ;
        }
    }
}

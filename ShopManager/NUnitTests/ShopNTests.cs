﻿using System;
using System.Collections.Generic;
using NUnit.Framework;
using ShopManager.Exceptions;
using System.Collections;

namespace ShopManager.NUnitTests
{
    [TestFixture]
    class ShopNTests
    {
        [Test]
        public void GetNameTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> wareBar = new Dictionary<long, Shop.ShopEntry>();
            wareBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", wareBar);
            Assert.AreEqual("Little Shop of Horrors", sh.GetName());
        }

        [Test]
        public void GetAddressTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> wareBar = new Dictionary<long, Shop.ShopEntry>();
            wareBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", wareBar);
            Assert.AreEqual("Nowhere City, 6666, 10, Downing Str.", sh.GetAddress());
        }

        [Test]
        public void GetOwnerTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> wareBar = new Dictionary<long, Shop.ShopEntry>();
            wareBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", wareBar);
            Assert.AreEqual("Dr. Acula", sh.GetOwner());
        }

        [Test]
        public void IsAnyCertainWareTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> wareBar = new Dictionary<long, Shop.ShopEntry>();
            wareBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", wareBar);
            Assert.AreEqual(true, sh.IsAnyCertainWare(typeof(LonglifeMilk)));
        }

        [Test]
        public void IsAnyMilkTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> wareBar = new Dictionary<long, Shop.ShopEntry>();
            wareBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", wareBar);
            Assert.AreEqual(true, sh.IsAnyMilk());
        }

        [Test]
        public void BuyWareTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            sh.Opens();
            sh.AddNewWare(newMilk, 200, 3);
            Dictionary<long, Shop.ShopEntry> foodBar = sh.GetWareBar();
            Shop.ShopEntry se = foodBar[newMilk.GetBarcode()];
            int quantity = se.GetQuantity();
            sh.BuyWare(newMilk.GetBarcode(), 1);
            Assert.AreEqual(quantity - 1, se.GetQuantity());
        }

        [Test]
        public void BuyWareThrowsClosedExceptionTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            sh.AddNewWare(newMilk, 200, 3);
            Dictionary<long, Shop.ShopEntry> foodBar = sh.GetWareBar();
            Shop.ShopEntry se = foodBar[newMilk.GetBarcode()];
            Assert.Throws<ClosedException>(() => sh.BuyWare(newMilk.GetBarcode(), 4), "The shop is closed.");
        }

        [Test]
        public void BuyWareThrowsTooMuchDecrementionExceptionTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            sh.Opens();
            sh.AddNewWare(newMilk, 200, 3);
            Dictionary<long, Shop.ShopEntry> foodBar = sh.GetWareBar();
            Shop.ShopEntry se = foodBar[newMilk.GetBarcode()];
            Assert.Throws<TooMuchDecrementionException>(() => sh.BuyWare(newMilk.GetBarcode(), 4), "The quantity of this product is not enough to buy!");
        }

        [Test]
        public void BuyWareThrowsNonexistentWareExceptionTest()
        { 
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop.ShopEntry shopEntry = new Shop.ShopEntry(newMilk, 20, 200);
            Dictionary<long, Shop.ShopEntry> wareBar = new Dictionary<long, Shop.ShopEntry>();
            wareBar.Add(newMilk.GetBarcode(), shopEntry);
            Shop shop = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", wareBar);
            shop.Opens();
            Assert.Throws<NonexistentWareException>(() => shop.BuyWare(821456607, 3), "Product with this barcode does not exists!");
        }

        [Test]
        public void AddNewWareTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            sh.AddNewWare(newMilk, 200, 1);
            Dictionary<long, Shop.ShopEntry> wareBar = sh.GetWareBar();
            Shop.ShopEntry se = wareBar[newMilk.GetBarcode()];
            Assert.AreEqual(1, se.GetQuantity());
        }

        [Test]
        public void AddNewWareTestThrowsArgumentException()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            sh.AddNewWare(newMilk, 200, 1);
            Dictionary<long, Shop.ShopEntry> wareBar = sh.GetWareBar();
            Shop.ShopEntry se = wareBar[newMilk.GetBarcode()];
            Assert.Throws<ArgumentException>(() => sh.AddNewWare(newMilk, 200, 1), "The product with this specific barcode already exists!");
        }

        [Test]
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

        [Test]
        public void AddWareThrowsNonexistentWareExceptionTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop.ShopEntry shopEntry = new Shop.ShopEntry(newMilk, 20, 200);
            Dictionary<long, Shop.ShopEntry> wareBar = new Dictionary<long, Shop.ShopEntry>();
            wareBar.Add(newMilk.GetBarcode(), shopEntry);
            Shop shop = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", wareBar);
            Assert.Throws<NonexistentWareException>(() => shop.AddWare(821456607, 3), "Product with this barcode does not exists!");
        }

        [Test]
        public void RemoveWareTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            sh.AddNewWare(newMilk, 200, 1);
            sh.RemoveWare(820716);
            Dictionary<long, Shop.ShopEntry> wareBar = sh.GetWareBar();
            Assert.AreEqual(false, wareBar.ContainsKey(newMilk.GetBarcode()));
        }

        [Test]
        public void RemoveWareThrowsNonexistentWareTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            sh.AddNewWare(newMilk, 200, 1);
            Dictionary<long, Shop.ShopEntry> wareBar = sh.GetWareBar();
            Assert.Throws<NonexistentWareException>(() => sh.RemoveWare(821456607), "Product with this barcode does not exists!"); ;
        }

        [Test]
        public void GetWaresTest()
        {
            LonglifeMilk milk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop shop = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            shop.Opens();
            shop.AddNewWare(milk, 200, 1);
            Dictionary<long, Shop.ShopEntry> wareBar = shop.GetWareBar();
            Shop.ShopEntry se = wareBar[milk.GetBarcode()];
            IEnumerator shopEnum = shop.GetWares();
            Assert.IsTrue(shopEnum.MoveNext());
        }

        [Test]
        public void MoveNextTest()
        {
            LonglifeMilk milk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop shop = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            shop.Opens();
            shop.AddNewWare(milk, 200, 1);
            Dictionary<long, Shop.ShopEntry> wareBar = shop.GetWareBar();
            Shop.ShopEntry se = wareBar[milk.GetBarcode()];
            IEnumerator shopEnum = shop.GetWares();
            Assert.IsTrue(shopEnum.MoveNext());
            Assert.IsFalse(shopEnum.MoveNext());
        }

        [Test]
        public void ResetTest()
        {
            LonglifeMilk milk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop shop = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            shop.Opens();
            shop.AddNewWare(milk, 200, 1);
            Dictionary<long, Shop.ShopEntry> wareBar = shop.GetWareBar();
            Shop.ShopEntry se = wareBar[milk.GetBarcode()];
            IEnumerator shopEnum = shop.GetWares();
            Assert.IsTrue(shopEnum.MoveNext());
            shopEnum.Reset();
            Assert.IsTrue(shopEnum.MoveNext());
        }

        [Test]
        public void ClosesTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop.ShopEntry shopEntry = new Shop.ShopEntry(newMilk, 20, 200);
            Dictionary<long, Shop.ShopEntry> wareBar = new Dictionary<long, Shop.ShopEntry>();
            wareBar.Add(newMilk.GetBarcode(), shopEntry);
            Shop shop = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", wareBar);
            shop.Opens();
            shop.Closes();
            Assert.Throws<ClosedException>(() => shop.BuyWare(newMilk.GetBarcode(), 4), "The shop is closed.");
        }

        [Test]
        public void OpensTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula");
            sh.Opens();
            sh.AddNewWare(newMilk, 200, 3);
            Dictionary<long, Shop.ShopEntry> foodBar = sh.GetWareBar();
            Shop.ShopEntry se = foodBar[newMilk.GetBarcode()];
            int quantity = se.GetQuantity();
            sh.BuyWare(newMilk.GetBarcode(), 1);
            Assert.AreEqual(quantity - 1, se.GetQuantity());
        }
    }
}

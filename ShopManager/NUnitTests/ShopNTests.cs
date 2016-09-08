using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ShopManager.NUnitTests
{
    [TestFixture]
    class ShopNTests
    {
        [Test]
        public void GetNameTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> milkBar = new Dictionary<long, Shop.ShopEntry>();
            milkBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", milkBar);
            Assert.AreEqual("Little Shop of Horrors", sh.GetName());
        }

        [Test]
        public void GetAddressTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> milkBar = new Dictionary<long, Shop.ShopEntry>();
            milkBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", milkBar);
            Assert.AreEqual("Nowhere City, 6666, 10, Downing Str.", sh.GetAddress());
        }

        [Test]
        public void GetOwnerTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> milkBar = new Dictionary<long, Shop.ShopEntry>();
            milkBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", milkBar);
            Assert.AreEqual("Dr. Acula", sh.GetOwner());
        }

        [Test]
        public void IsAnyMilkTest()
        {
            Shop.ShopEntry s1 = new Shop.ShopEntry((new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8)), 1, 200);
            Dictionary<long, Shop.ShopEntry> milkBar = new Dictionary<long, Shop.ShopEntry>();
            milkBar.Add(890818, s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", milkBar);
            Assert.AreEqual(true, sh.IsAnyMilk());
            Assert.AreEqual(true, sh.IsAnyMilk());
        }

        [Test]
        public void BuyMilkTest()
        {
            LonglifeMilk newMilk = new LonglifeMilk(890818, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 8, 18), 2.8);
            Shop.ShopEntry s1 = new Shop.ShopEntry(newMilk, 1, 200);
            Dictionary<long, Shop.ShopEntry> milkBar = new Dictionary<long, Shop.ShopEntry>();
            milkBar.Add(newMilk.GetBarcode(), s1);
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", milkBar);
            Assert.AreEqual(sh.BuyMilk(newMilk.GetBarcode()), newMilk); ;
        }

        [Test]
        public void AddMilkTest()
        {
            Dictionary<long, Shop.ShopEntry> milkBar = new Dictionary<long, Shop.ShopEntry>();
            Shop sh = new Shop("Little Shop of Horrors", "Nowhere City, 6666, 10, Downing Str.", "Dr. Acula", milkBar);
            LonglifeMilk newMilk = new LonglifeMilk(820716, 1000, "Sole-Mizo ZRt.", new DateTime(2016, 9, 18), 2.8);
            sh.AddMilk(newMilk);
            Assert.AreEqual(newMilk, milkBar[newMilk.GetBarcode()].GetM());
        }
    }
}

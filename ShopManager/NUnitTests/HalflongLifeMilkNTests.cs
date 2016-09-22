using System;
using NUnit.Framework;

namespace ShopManager.NTests
{
    [TestFixture]
    public class HalfongLifeMilkTests
    {
        [Test]
        public void GetBarcodeTest()
        {
            HalflongLifeMilk m = new HalflongLifeMilk(678524, 1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8);
            Assert.AreEqual(678524, m.GetBarcode());
        }

        [Test]
        public void GetCapacityTest()
        {
            HalflongLifeMilk m = new HalflongLifeMilk(678524, 1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8);
            Assert.AreEqual(1000, m.GetCapacity());
        }

        [Test]
        public void GetCompanyTest()
        {
            HalflongLifeMilk m = new HalflongLifeMilk(678524, 1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8);
            Assert.AreEqual("Tej Rt.", m.GetCompany());
        }

        [Test]
        public void GetWarrantTest()
        {
            HalflongLifeMilk m = new HalflongLifeMilk(678524, 1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8);
            Assert.AreEqual((new DateTime(2016, 9, 1)), m.GetWarrant());
        }

        [Test]
        public void GetDrippingTest()
        {
            HalflongLifeMilk m = new HalflongLifeMilk(678524, 1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8);
            Assert.AreEqual(2.8, m.GetDripping());
        }

        [Test]
        public void IsGoodTest()
        {
            HalflongLifeMilk m = new HalflongLifeMilk(678524, 1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8);
            Assert.AreEqual(false, m.IsGood());
        }

        [Test]
        public void ToStringTest()
        {
            HalflongLifeMilk m = new HalflongLifeMilk(678524, 1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8);
            // Be cHalflongLifeMilkareful: using '.' or ',' in double/float depends on environmental variables:
            Assert.AreEqual("Produced by: Tej Rt. Best before: 2016.09.01. 0:00:00 Dripping: 2,8", m.ToString());
        }
    }
}
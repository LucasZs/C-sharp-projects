using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ShopManager.NUnitTests
{
    [TestFixture]
    class MilkNTests
    {
        [Test]
        public void GetBarcodeTest()
        {
            Milk m = new Milk(678524, 1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8);
            Assert.AreEqual(678524, m.GetBarcode());
        }

        [Test]
        public void GetCapacityTest()
        {
            Milk m = new Milk(678524, 1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8);
            Assert.AreEqual(1000, m.GetCapacity());
        }

        [Test]
        public void GetCompanyTest()
        {
            Milk m = new Milk(678524, 1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8);
            Assert.AreEqual("Tej Rt.", m.GetCompany());
        }

        [Test]
        public void GetWarrantTest()
        {
            Milk m = new Milk(678524, 1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8);
            Assert.AreEqual((new DateTime(2016, 9, 1)), m.GetWarrant());
        }

        [Test]
        public void GetDrippingTest()
        {
            Milk m = new Milk(678524, 1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8);
            Assert.AreEqual(2.8, m.GetDripping());
        }

        [Test]
        public void IsGoodTest()
        {
            Milk m = new Milk(678524, 1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8);
            Assert.AreEqual(true, m.IsGood());
        }

        [Test]
        public void ToStringTest()
        {
            Milk m = new Milk(678524, 1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8);
            // Be careful: using '.' or ',' in double/float depends on environmental variables:
            Assert.AreEqual("Produced by: Tej Rt. Best before: 2016.09.01. 0:00:00 Dripping: 2,8", m.ToString());
        }
    }
}

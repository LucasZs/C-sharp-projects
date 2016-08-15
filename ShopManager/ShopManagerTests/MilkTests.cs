using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.Tests
{
    [TestClass()]
    public class MilkTests
    {
        [TestMethod()]
        public void GetCapacityTest()
        {
            Milk m = new Milk(1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8, 200);
            Assert.AreEqual(1000, m.GetCapacity());
        }

        [TestMethod()]
        public void GetCompanyTest()
        {
            Milk m = new Milk(1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8, 200);
            Assert.AreEqual("Tej Rt.", m.GetCompany());
        }

        [TestMethod()]
        public void GetWarrantTest()
        {
            Milk m = new Milk(1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8, 200);
            Assert.AreEqual((new DateTime(2016, 9, 1)), m.GetWarrant());
        }

        [TestMethod()]
        public void GetDrippingTest()
        {
            Milk m = new Milk(1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8, 200);
            Assert.AreEqual(2.8, m.GetDripping());
        }

        [TestMethod()]
        public void GetPriceTest()
        {
            Milk m = new Milk(1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8, 200);
            Assert.AreEqual(200, m.GetPrice());
        }

        [TestMethod()]
        public void IsGoodTest()
        {
            Milk m = new Milk(1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8, 200);
            Assert.AreEqual(true, m.IsGood());
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Milk m = new Milk(1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8, 200);
            // Be careful: using '.' or ',' in double/float depends on environmental variables:
            Assert.AreEqual("Produced by: Tej Rt. Best before: 2016.09.01. 0:00:00 Dripping: 2,8", m.ToString());
        }
    }
}
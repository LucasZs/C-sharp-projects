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
        public void getCapacityTest()
        {
            Milk m = new Milk(1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8, 200);
            Assert.AreEqual(1000, m.getCapacity());
        }

        [TestMethod()]
        public void getCompanyTest()
        {
            Milk m = new Milk(1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8, 200);
            Assert.AreEqual("Tej Rt.", m.getCompany());
        }

        [TestMethod()]
        public void getWarrantTest()
        {
            Milk m = new Milk(1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8, 200);
            Assert.AreEqual((new DateTime(2016, 9, 1)), m.getWarrant());
        }

        [TestMethod()]
        public void getDrippingTest()
        {
            Milk m = new Milk(1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8, 200);
            Assert.AreEqual(2.8, m.getDripping());
        }

        [TestMethod()]
        public void getPriceTest()
        {
            Milk m = new Milk(1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8, 200);
            Assert.AreEqual(200, m.getPrice());
        }

        [TestMethod()]
        public void isGoodTest()
        {
            Milk m = new Milk(1000, "Tej Rt.", new DateTime(2016, 9, 1), 2.8, 200);
            Assert.AreEqual(true, m.isGood());
        }
     }
}
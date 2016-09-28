using KellermanSoftware.CompareNetObjects;
using NUnit.Framework;
using System;

namespace ShopManager.NTests
{
    [TestFixture]
    class WareFactoryNTests
    {
        readonly long barcode = 820716;
        readonly int capacity = Milk.LITER;
        readonly string company = "MoreMilk&Soap Ltd.";
        readonly DateTime warrant = new DateTime(2018, 12, 31);
        readonly double dripping = Milk.FAT;
        readonly char washEffect = 'C';

        public bool Compare(object objectA, object objectB)
        {
            //Using Kellerman software - comparenetobjects.codeplex.com
            //www.nuget.org/packages/CompareNETObjects
            ComparisonConfig config = new ComparisonConfig { MaxDifferences = 100 };
            CompareLogic compareLogic = new CompareLogic(config);

            ComparisonResult result = compareLogic.Compare(objectA, objectB);
            return result.AreEqual;
        }

        [Test]
        public void CreateNewLonglifeMilk_TestWithCompare()
        {
            Milk milk1 = WareFactory.CreateNewHalflonglifeMilk(barcode, capacity, company, warrant, dripping);
            Milk milk2 = new LonglifeMilk(barcode, capacity, company, warrant, dripping);
            Assert.IsTrue(Compare(milk1, milk2));
        }

        [Test]
        public void CreateNewHalfFatLonglifeMilk_TestWithCompare()
        {
            Milk milk1 = WareFactory.CreateNewHalfFatLonglifeMilk(barcode, capacity, company, warrant);
            Milk milk2 = new LonglifeMilk(barcode, capacity, company, warrant, Milk.HALF_FAT);
            Assert.IsTrue(Compare(milk1, milk2));
        }

        [Test]
        public void CreateNewLiterHalfFatLonglifeMilk_TestWithCompare()
        {
            Milk milk1 = WareFactory.CreateNewLiterHalfFatLonglifeMilk(barcode, company, warrant);
            Milk milk2 = new LonglifeMilk(barcode, Milk.LITER, company, warrant, Milk.HALF_FAT);
            Assert.IsTrue(Compare(milk1, milk2));
        }

        [Test]
        public void CreateNewFatLonglifeMilk_TestWithCompare()
        {
            Milk milk1 = WareFactory.CreateNewFatLonglifeMilk(barcode, capacity, company, warrant);
            Milk milk2 = new LonglifeMilk(barcode, capacity, company, warrant, Milk.FAT);
            Assert.IsTrue(Compare(milk1, milk2));
        }

        [Test]
        public void CreateNewLiterFatLonglifeMilk_TestWithCompare()
        {
            Milk milk1 = WareFactory.CreateNewLiterFatLonglifeMilk(barcode, company, warrant);
            Milk milk2 = new LonglifeMilk(barcode, Milk.LITER, company, warrant, Milk.FAT);
            Assert.IsTrue(Compare(milk1, milk2));
        }

        [Test]
        public void CreateNewHalflongLifeMilk_TestWithCompare()
        {
            Milk milk1 = WareFactory.CreateNewHalflongLifeMilk(barcode, capacity, company, warrant, dripping);
            Milk milk2 = new HalflongLifeMilk(barcode, capacity, company, warrant, dripping);
            Assert.IsTrue(Compare(milk1, milk2));
        }

        [Test]
        public void CreateNewHalfFatHalflongLifeMilk_TestWithCompare()
        {
            Milk milk1 = WareFactory.CreateNewHalfFatHalflonglifeMilk(barcode, capacity, company, warrant);
            Milk milk2 = new HalflongLifeMilk(barcode, capacity, company, warrant, Milk.HALF_FAT);
            Assert.IsTrue(Compare(milk1, milk2));
        }

        [Test]
        public void CreateNewFatHalflongLifeMilk_TestWithCompare()
        {
            Milk milk1 = WareFactory.CreateNewFatHalflongLifeMilk(barcode, capacity, company, warrant);
            Milk milk2 = new HalflongLifeMilk(barcode, capacity, company, warrant, Milk.FAT);
            Assert.IsTrue(Compare(milk1, milk2));
        }

        [Test]
        public void CreateNewLiterHalfFatHalflongLifeMilk_TestWithCompare()
        {
            Milk milk1 = WareFactory.CreateNewLiterHalfFatHalflongLifeMilk(barcode, company, warrant);
            Milk milk2 = new HalflongLifeMilk(barcode, Milk.LITER, company, warrant, Milk.HALF_FAT);
            Assert.IsTrue(Compare(milk1, milk2));
        }

        [Test]
        public void CreateNewLiterFatHalflongLifeMilk_TestWithCompare()
        {
            Milk milk1 = WareFactory.CreateNewLiterFatHalflongLifeMilk(barcode, company, warrant);
            Milk milk2 = new HalflongLifeMilk(barcode, Milk.LITER, company, warrant, Milk.FAT);
            Assert.IsTrue(Compare(milk1, milk2));
        }

        [Test]
        public void CreateNewSoap_TestWithCompare()
        {
            Soap soap1 = WareFactory.CreateNewSoap(barcode, company, washEffect);
            Soap soap2 = new Soap(barcode, company, washEffect);
            Assert.IsTrue(Compare(soap1, soap2));
        }

        [Test]
        public void CreateNewSoapWithWashEffectA_TestWithCompare()
        {
            Soap soap1 = WareFactory.CreateNewSoapWithWashEffectA(barcode, company);
            Soap soap2 = new Soap(barcode, company, washEffect);
            Assert.IsTrue(Compare(soap1, soap2));
        }
    }
}
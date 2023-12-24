using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PetrovNE.Sprint7.Project0.V10.Lib;

namespace Tyuiu.PetrovNE.Sprint7.Project0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMax()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            int wait = 6;
            Assert.AreEqual(wait, ds.GetMaxValue(array));
        }

        [TestMethod]
        public void GetMin()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            int wait = 1;
            Assert.AreEqual(wait, ds.GetMinValue(array));
        }

        [TestMethod]
        public void GetAverage()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            double wait = 3.5;
            Assert.AreEqual(wait, ds.GetAverageValue(array));
        }

        [TestMethod]
        public void GetSum()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            int wait = 21;
            Assert.AreEqual(wait, ds.GetSumValue(array));
        }

        [TestMethod]
        public void GetCount()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            int wait = 6;
            Assert.AreEqual(wait, ds.GetCountValue(array));
        }
    }
}

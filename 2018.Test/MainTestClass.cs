using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2018.September;
namespace _2018.Test
{
    [TestClass]
    public class MainTestClass
    {
        [TestMethod]
        public void Sept26Test_One()
        {
            var args = new int[] { 3, 5, 7, 12, 44, 69 };
            var target = 51;
            var result = new Sept26().twoSum(args,target);
            Assert.AreEqual(result[0], 2);
            Assert.AreEqual(result[1], 4);
        }
    }
}

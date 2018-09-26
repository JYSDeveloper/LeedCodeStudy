using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2018.September;
namespace _2018.Test
{
    [TestClass]
    public class MainTestClass
    {
        [TestMethod]
        public void Sep26Test_One()
        {
            var args = new int[] { 3, 5, 7, 12, 44, 69 };
            var target = 51;
            var result = new Sep26().twoSum(args,target);
            Assert.AreEqual(result[0], 2);
            Assert.AreEqual(result[1], 4);
        }
        [TestMethod]
        public void Sep26Test_Two()
        {
            var args = new int[] { 3, 5, 7, 8, 44, 69 };
            var target = 15;
            var result = new Sep26().twoSum(args, target);
            Assert.AreEqual(result[0], 2);
            Assert.AreEqual(result[1], 3);
        }
        [TestMethod]
        public void Sep26Test_Three()
        {
            var args = new int[] { 3, 5, 7, 8, 44, 69 };
            var target = 25;
            var result = new Sep26().twoSum(args, target);
            Assert.IsNull(result);
        }
    }
}

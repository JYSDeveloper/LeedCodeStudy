using System;
using _2018.September;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2018.Test
{
    [TestClass]
    public class Sep
    {
        #region Sep26
        [TestMethod]
        public void Sep26Test_One()
        {
            var args = new int[] { 3, 5, 7, 12, 44, 69 };
            var target = 51;
            var result = new Sep26().twoSum(args, target);
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
        #endregion
        #region Sep27
        [TestMethod]
        public void Sep27Test_One()
        {
            //Test Max & Min value
            var input = int.MaxValue;
            var result = Sep27.Reverse(input);
            Assert.AreEqual(result, 0);
            result = Sep27.Reverse(int.MinValue);
            Assert.AreEqual(result, 0);
        }
        [TestMethod]
        public void Sep27Test_Two()
        {
            //Normal Test
            Assert.AreEqual(Sep27.Reverse(123), 321);
            Assert.AreEqual(Sep27.Reverse(-123), -321);
            Assert.AreEqual(Sep27.Reverse(120), 21);
        }
        #endregion
    }
}

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
            var args = new int[] {230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789};
            var target = 542;
            var result = new Sep26().twoSum(args, target);
            //Assert.AreEqual(result[0], 2);
            //Assert.AreEqual(result[1], 4);
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
        #region
        [TestMethod]
        public void Sep28Test_One()
        {
            Assert.IsTrue(Sep28.IsPalindrome(123456654321));
            Assert.IsFalse(Sep28.IsPalindrome(-121));
            Assert.IsFalse(Sep28.IsPalindrome(10));
            Assert.IsTrue(Sep28.IsPalindrome(121));
        }
        #endregion
    }
}

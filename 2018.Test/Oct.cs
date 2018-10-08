using System;
using _2018.October;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2018.Test
{
    [TestClass]
    public class Oct
    {
        #region Oct-08
        [TestMethod]
        public void Oct08Test_One()
        {
            Assert.AreEqual(Oct08.RomanToInt("III"), 3);
            Assert.AreEqual(Oct08.RomanToInt("IV"), 4);
            Assert.AreEqual(Oct08.RomanToInt("IX"), 9);
            Assert.AreEqual(Oct08.RomanToInt("LVIII"), 58);
            Assert.AreEqual(Oct08.RomanToInt("MCMXCIV"), 1994);
        }
        #endregion
    }
}

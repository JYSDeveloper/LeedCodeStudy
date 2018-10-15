﻿using System;
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

        #region Oct-09
        [TestMethod]
        public void Oct09Test_One()
        {
            var t = Oct09.longestCommonPrefix(new string[] { "abc", "bc" });
            Console.WriteLine(t);
        }
        #endregion

        #region Oct-11
        [TestMethod]
        public void Oct11Test_One()
        {
            string test = @"(({{}}))";
            Assert.IsTrue(Oct11.IsValid(test));
        }
        #endregion

        #region Oct-15
        [TestMethod]
        public void Oct15_TestOne()
        {
            var one = new ListNode(1);
            var two = new ListNode(2);
            var three = new ListNode(3);
            var five = new ListNode(5);
            var six = new ListNode(6);
            var seven = new ListNode(7);
            var eight = new ListNode(8);
            var night = new ListNode(9);

            one.next = two;
            two.next = five;
            five.next = seven;

            three.next = six;
            six.next = eight;
            eight.next = night;

            var temp = Oct15.MergeTwoLists(one, three);
        }
        #endregion
    }
}

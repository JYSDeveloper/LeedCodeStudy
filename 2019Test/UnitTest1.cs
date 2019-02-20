using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2019;

namespace _2019Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var n1 = new SingleLinkedList<int>(1);
            var n2 = new SingleLinkedList<int>(2);
            var n3 = new SingleLinkedList<int>(3);
            var n4 = new SingleLinkedList<int>(4);
            var n5 = new SingleLinkedList<int>(5);
            var n6 = new SingleLinkedList<int>(6);
            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;
            n5.Next = n6;

            n1.Show();

            //var result = SingleLinkedList<int>.SwapPairs(n1);
            //result.Show();
            //Console.WriteLine(SingleLinkedList<int>.isCircle(n1));
            SingleLinkedList<int>.ReverseLinkedList(n1).Show();
            
        }
    }
}

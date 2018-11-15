using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018.HelperEntity
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public static ListNode ConvertByIntNumber(int val)
        {
            var result = new ListNode(val % 10);
            var temp = result;
            while (val / 10 != 0)
            {
                val /= 10;
                temp.next = new ListNode(val % 10);
                temp = temp.next;
            }

            return result;
        }
    }
}

using _2018.HelperEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018.November
{
    //You are given two non-empty linked lists representing two non-negative integers.
    //The digits are stored in reverse order and each of their nodes contain a single digit.
    //Add the two numbers and return it as a linked list.
    //You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    //Example:
    //Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    //Output: 7 -> 0 -> 8
    //Explanation: 342 + 465 = 807.
    public static class No2_AddTwoNumbers
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode p = l1, q = l2, curr = dummyHead;
            int carry = 0;
            while (p != null || q != null)
            {
                int x = (p != null) ? p.val : 0;
                int y = (q != null) ? q.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }
            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }
            return dummyHead.next;
        }

        public static void ReLoad(ListNode node)
        {
            while (node !=null)
            {
                if(node.val >= 10)
                    if (node.next == null)
                        node.next = new ListNode(1);
                    else
                        node.next.val++;

                node.val %= 10;
                node = node.next;
            }
        }

        public static ListNode AddTwoNumbersWithoutReload(ListNode l1, ListNode l2, int carry)
        {
            int sum = l1.val + l2.val + carry;
            var result = new ListNode(sum % 10);
            if (l1.next == null || l2.next == null)
            {
                if (l1.next == null && l2.next == null)
                    result.next = sum >= 10 ? new ListNode(sum / 10) : null;
                else
                {
                    result.next = l1.next ?? l2.next;
                    result.next.val += sum / 10;
                }
            }
            else
                result.next = AddTwoNumbersWithoutReload(l1.next, l2.next, sum / 10);
            return result;
        }

    }
}

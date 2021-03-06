﻿
using _2018.HelperEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018.October
{
    public static class Oct15
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            if (l1.val < l2.val) {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists(l2.next, l1);
                return l2;
            }
        }
    }
}

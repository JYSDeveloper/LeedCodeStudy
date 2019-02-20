using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2019
{
    public class SingleLinkedList<T>
    {
        public T Value { get; set; }
        public SingleLinkedList<T> Next { get; set; }

        public SingleLinkedList(T value)
        {
            Value = value;
        }
        /// <summary>
        /// 输出链表
        /// </summary>
        public void Show()
        {
            var temp = this;
            Console.Write($"{temp.Value} -> ");
            while (temp.Next != null)
            {
                temp = temp.Next;
                Console.Write($"{temp.Value} -> ");
            }

            Console.WriteLine("Null");
        }
        /// <summary>
        /// 链表节点两两交换
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static SingleLinkedList<T> SwapPairs(SingleLinkedList<T> head)
        {
            if (head == null || head.Next == null)
                return head;
            var temp = head.Next;
            head.Next = SwapPairs(head.Next.Next);
            temp.Next = head;
            head = temp;
            return head;
        }
        /// <summary>
        /// 链表是否有环
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static bool isCircle(SingleLinkedList<T> head)
        {
            if (head == null || head.Next == null)
                return false;
            var slow = head;
            var fast = head.Next;
            while (slow != fast)
            {
                if (fast == null || fast.Next == null)
                    return false;
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return true;
        }

        public static SingleLinkedList<T> ReverseLinkedList(SingleLinkedList<T> head)
        {
            SingleLinkedList<T> prev = null;
            var curr = head;
            while (curr != null)
            {
                var nextTemp = curr.Next;
                curr.Next = prev;//当前的下一个等于之前的那个值
                prev = curr;//之前元素等于当前元素
                curr = nextTemp;//当前元素等于下一个，继续遍历
                
            }

            return prev;
        }

        public static SingleLinkedList<T> ReverseKGroup(SingleLinkedList<T> head, int k)
        {
            if (head == null) return head;
            var t = head;
            int n = 0;
            while (t != null)
            {
                t = t.Next;
                n++;
            }

            if (n < k)
                return head;

            int inx = 0;
            SingleLinkedList<T> next = null;
            var cur = head;
            SingleLinkedList<T> pre = null;
            while (inx < k)
            {
                next = cur.Next;
                cur.Next = pre;
                pre = cur;
                cur = next;
                inx++;
            }

            if (n - k >= k)
                head.Next = ReverseKGroup(next, k);
            else
                head.Next = next;

            return pre;

        }

    }
}

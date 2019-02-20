using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}

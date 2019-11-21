using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOI
{
    public class AOIDoubleLinkedList
    {
        private AOILinkedListNode head;
        private AOILinkedListNode tail;

        public AOIDoubleLinkedList()
        {
            head = new AOILinkedListNode();
            tail = new AOILinkedListNode();
            head.Next = tail;
            tail.Prev = head;
        }

        public void Insert(AOILinkedListNode node)
        {
            if (head.Next == tail)
            {
                head.Next = node;
                node.Next = tail;
                node.Prev = head;
                tail.Prev = node;
            }
            else
            {
                AOILinkedListNode h = head.Next;
                while (h!=tail && h.Data < node.Data)
                {
                    h = h.Next;
                }
                AOILinkedListNode prev = h.Prev;
                prev.Next = node;
                h.Prev = node;
                node.Next = h;
                node.Prev = prev;
            }
        }
    }
}

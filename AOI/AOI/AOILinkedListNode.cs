using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOI
{
    public class AOILinkedListNode
    {
        public AOILinkedListNode Prev;
        public AOILinkedListNode Next;
        public float Data; 

        public AOILinkedListNode()
        {
            Prev = null;
            Next = null;
        }
    }
}

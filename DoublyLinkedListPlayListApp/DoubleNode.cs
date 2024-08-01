using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DoublyLinkedListPlayListApp
{
    public class DoubleNode
    {
        internal Track track;
        internal DoubleNode prev;
        internal DoubleNode next;
        public DoubleNode(Track trac)
        {
            track  = trac;
            prev = null;
            next = null;
        }

        
    }
}

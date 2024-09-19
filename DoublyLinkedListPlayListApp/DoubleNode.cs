using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DoublyLinkedListPlayListApp
{//Code Attribution
 //This code was adapted from C# Corner
 //https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/
 //Ankit Sharma
 //https://www.c-sharpcorner.com/members/ankit-sharma93
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

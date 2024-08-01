using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DoublyLinkedListPlayListApp
{
    internal class DoublyLinkedList
    {
        internal DoubleNode head;
        private int Count { get; set; }
        

        internal void InsertLast(DoublyLinkedList doubleLinkedList, Track track)
        {
            DoubleNode newNode = new DoubleNode(track);
            if (doubleLinkedList.head == null)
            {
                newNode.prev = null;
                doubleLinkedList.head = newNode;
                return;
            }
            DoubleNode lastNode = GetLastNode(doubleLinkedList);
            lastNode.next = newNode;
            newNode.prev = lastNode;
            newNode.next = doubleLinkedList.head;
            doubleLinkedList.head.prev = newNode;
            Count++;
        }
        internal void InsertAfter(DoubleNode prev_node, Track track)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node cannot be null");
                return;
            }
            DoubleNode newNode = new DoubleNode(track);
            newNode.next = prev_node.next;
            prev_node.next = newNode;
            newNode.prev = prev_node;
            if (newNode.next != null)
            {
                newNode.next.prev = newNode;
            }
        }

        internal DoubleNode GetLastNode(DoublyLinkedList doubleLinkedList)
        {
            DoubleNode temp = doubleLinkedList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        internal string NextNode(DoublyLinkedList doubleLinkedList, string name)
        {
            DoubleNode temp = doubleLinkedList.head;
            DoubleNode doubleNode = null;
            while (temp != null)
            {
                if (temp != null && temp.track.TrackName.Equals(name))
                {
                    if (temp.next != null)
                    {
                        doubleNode = temp.next;
                    }
                }
                temp.prev = temp;
                temp = temp.next;
            }

            if (temp != null)
            {
                doubleNode = doubleLinkedList.head;
            }
            return doubleNode.track.TrackName.ToString();
        }

        internal string PreviousNode(DoublyLinkedList doubleLinkedList, string name)
        {
            DoubleNode temp = doubleLinkedList.head;
            DoubleNode doubleNode = null;
            while (temp != null)
            {
                if (temp != null && temp.track.TrackName.Equals(name))
                {
                    if (temp.prev != null)
                    {
                        doubleNode = temp.prev;
                    }
                }
                temp.prev = temp;
                temp = temp.next;
            }
            return doubleNode.prev.track.TrackName.ToString();
        }

        internal void DeleteNode(DoublyLinkedList doubleLinkedList, string name)
        {
            DoubleNode temp = doubleLinkedList.head;
            
            while (temp != null && !temp.track.TrackName.Equals(name))
            {
                if (temp.next == doubleLinkedList.head)
                {
                    temp.prev.next = doubleLinkedList.head;
                }
                
                if( doubleLinkedList.head.prev == temp)
                {
                    doubleLinkedList.head.prev = temp.prev;

                }
                if(!(temp.next == doubleLinkedList.head) && !(doubleLinkedList.head.prev == temp))
                {
                    temp = temp.next;
                }

            }

            if (temp == null)
            {
                return;
            }
            if (temp.next != null)
            {
                temp.next.prev = temp.prev;
            }
            if (temp.prev != null)
            {
                temp.prev.next = temp.next;
            }

        }

        public string FindNode(DoublyLinkedList doubleLinkedList, string name)
        {
            DoubleNode temp = doubleLinkedList.head;
            DoubleNode prev = null;
            string answer = " ";
            if (temp != null && temp.track.TrackName.Equals(name))
            {
                doubleLinkedList.head = temp.next;
                return temp.track.TrackName.ToString();
            }
            while (temp != null)
            {

                if (temp != null && temp.track.TrackName.Equals(name))
                {
                    doubleLinkedList.head = temp.next;
                    answer = temp.track.TrackName.ToString();
                }
                else
                {
                    prev = temp;
                    temp = temp.next;
                }
            }
            if (answer.Equals(" "))
            {
                answer = "Not found";
            }
            return answer;

        }

        
        public int GetCount(DoublyLinkedList doubleLinkedList) {

            return Count;
        }

        public string GetNode(DoublyLinkedList doubleLinkedList, int index)
        {
            string answer = "";
            int step=0;
            DoubleNode temp = doubleLinkedList.head;
           
                while (temp != null && step <= index)
                {
                    answer = temp.track.TrackName.ToString();
                    temp = temp.next;
                    step++;
            }
            
            return answer;
        }

    }
}

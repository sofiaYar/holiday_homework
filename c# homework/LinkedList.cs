using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class LinkedList1 : IEnumerable
    {
        public Node ListHead {  get; set; }
        private Node listTail;
        private Node maxNode;
        private Node minNode;
        public LinkedList1() 
        {
            ListHead = null;
            listTail = null;
            maxNode = ListHead;
            minNode = ListHead;
        }

        public LinkedList1(int value ,Node next) 
        {
            ListHead = new Node(value,next);
            listTail = ListHead;
            maxNode = ListHead;
            minNode = ListHead;


        }

        public void Append(int value)
        {
            if (ListHead != null)
            {
                listTail.Next = new Node(value);
                listTail = listTail.Next;
                UpdateMinMax(listTail);
            }
            else
            {
                ListHead = new Node(value);
                listTail = ListHead;
                maxNode = ListHead;
                minNode = ListHead;

            }
        }

        public void Prepend(int value)
        {
            if ( ListHead == null)
            {
                ListHead = new Node(value);
            }
            else
            {
                Node postion = new Node(value);
                postion.Next = ListHead;
                ListHead = postion;
                UpdateMinMax(ListHead);
            }
           
        }

        public int Pop() 
        {
            int value = listTail.Value;
            Node pos = ListHead;
            while (pos.Next != listTail) 
            { 
                pos = pos.Next;
            }
            pos.Next = null;
            RecalculateMinMax(listTail);
            listTail = pos;
            return value;
        }

        public int Unqueue()
        {
            int value = ListHead.Value;
            RecalculateMinMax(ListHead);

            ListHead = ListHead.Next;
            return value;
        }

        public IEnumerator ToList()
        {
            Node current = ListHead;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ToList();
        }

        public bool IsCircular()
        {
            if (listTail.Next == ListHead)
            {
                return true;
            }
            return false;
        }

        public LinkedList1 Sort()
        {
            LinkedList1 sortedList = new LinkedList1();

            Node pos = ListHead;
            while (pos != null) 
            {
                sortedList.Append(pos.Value);
                pos = pos.Next;
            }


            sortedList.SortInternal();

            return sortedList;
        }

        private void SortInternal()
        {
            bool swapped;
            do
            {
                swapped = false;
                Node current = ListHead;
                while (current != null && current.Next != null)
                {
                    if (current.Value.CompareTo(current.Next.Value) > 0)
                    {
                        int temp = current.Value;
                        current.Value = current.Next.Value;
                        current.Next.Value = temp;
                        swapped = true;
                    }
                    current = current.Next;
                }
            } while (swapped);
        }

        
        private void UpdateMinMax(Node value)
        {
            if (value.Value > maxNode.Value)
            {
                maxNode = value;
            }
            else if (value.Value < minNode.Value)
            {
                minNode = value;
            }
        }

        private void RecalculateMinMax(Node value)
        {
            if (value.Value == maxNode.Value)
            {   maxNode.Value = int.MinValue;
                Node position = ListHead;
                while (position != null)
                {
                    if( maxNode.Value < position.Value)
                    {
                        maxNode = position;
                    }
                    position = position.Next;
                }
            }
            if (value.Value == minNode.Value)
            {
                minNode.Value = int.MaxValue;
                Node position = ListHead;
                while (position != null)
                {
                    if (minNode.Value > position.Value)
                    {
                        minNode = position;
                    }
                    position = position.Next;
                }
            }
        }
        
        public Node GetMaxNode()
        {
            return maxNode;
        }

        public Node GetMinNode()
        {
            return minNode;
        }
    }
}

﻿namespace ConsoleApp1
{

    public class Node
    {

        public int Value
        {
            get; set;
        }

        public Node Next
        {
            get; set;
        }



        public Node(int value)
        {
            Value = value;
            Next = null;
        }



        public Node(int value, Node next)
        {
            Value = value;
            Next = next;
        }



        public bool HasNext()
        {
            return (Next != null);
        }



    }
}

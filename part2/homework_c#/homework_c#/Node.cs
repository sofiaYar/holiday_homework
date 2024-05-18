using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_c_
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




    }
}

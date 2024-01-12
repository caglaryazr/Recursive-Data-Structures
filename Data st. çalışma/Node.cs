using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_st._çalışma
{
    internal class Node
    {
        public int data;
        public Node next;
        public Node prev;
        public Node Right;
        public Node Left;

        public Node(int data)
        {
            this.data = data;
            next = null;
            prev = null;
            Right = null;
            Left = null;
        }
    }
}

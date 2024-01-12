using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Data_st._çalışma
{
    internal class BinaryTree
    {
        Node Root;
        
        public BinaryTree()
        {
            Root = null;
        }

        public void add(int data)
        {
            Node veri= new Node(data);
            if(Root==null)
            {
                Console.WriteLine("Binary Tree boş ilk eleman eklendi.");
                Root = veri;

            }
            else 
            {
                if(data<=Root.data)
                {
                    Console.WriteLine("Binary Tree'ye eleman eklendi.");
                    Root.Left= veri;
                }
                else
                {
                    Console.WriteLine("Binary Tree'ye eleman eklendi.");
                    Root.Right= veri;
                }
            }
        }
        
    }
}

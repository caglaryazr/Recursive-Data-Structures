using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_st._çalışma
{
    internal class Stack
    {
        Node top;
        public Stack() 
        {
            top = null;
        }

        public void push(int data)
        {
            Node veri= new Node(data);
            if(top==null)
            {
                Console.WriteLine("Stack'e ilk veri eklendi.");
                top = veri;
            }
            else
            {
                Console.WriteLine("Stack'e vari eklendi.");
                top.next = top;
                top = veri;
            }
        }
        public int pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack boş veri çıkartılamaz!");
                return -1;
            }
            else
            {
                Console.WriteLine("Stackten eleman çıkartılıdı.");
                int CıkanSayı = top.data;
                top = top.next;
                return CıkanSayı;
            }
        }

        public void Print()
        {
            if (top == null)
            {
                Console.WriteLine("Stack boş!");
            }
            else
            {
                Node temp= top;

                while (temp!=null)
                {
                    Console.WriteLine(temp);
                    temp= temp.next;
                }
            }

        }

    }
}

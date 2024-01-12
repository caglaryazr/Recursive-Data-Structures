using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_st._çalışma
{
    internal class Queue
    {
        Node Head;
        Node Tail;
        public Queue()
        {
            Head = null;
            Tail = null;

        }

        public void Enqueue(int data)
        {
            Node veri = new Node(data);
            if (Head == null)
            {
                Console.WriteLine("Queue'ye ilk veri eklendi.");
                Head = veri;
                Tail=veri;
            }
            else
            {
                Console.WriteLine("Queue'ye veri eklendi.");
                Head.prev = veri;
                Head = Head.prev;
            }
        }
        public int Dequeue()
        {
            if (Tail == null)
            {
                Console.WriteLine("Queue boş!");
                return -1;
            }
            else
            {
                int CıkanSayı = Tail.data;
                Console.WriteLine("Queue'den veri silindi.");
                Tail=Tail.prev;
                return CıkanSayı;
                
            }
        }
        public void Print()
        {
            if (Tail==null)
            {
                Console.WriteLine("Queue boş!");
            }
            else
            {
                Node temp = Head;

                while (temp != null)
                {
                    Console.WriteLine(temp);
                    temp = temp.next;
                }
            }

        }
    }
}

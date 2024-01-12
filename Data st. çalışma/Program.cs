using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack str = new Stack();
            str.push(1);
            str.push(2);
            str.push(3);
            str.push(4);

            str.print();
            str.pop();
            str.pop();
            str.print();

            Console.Clear();

            queue q = new queue();
            q.enqueue(1);
            q.enqueue(2);
            q.enqueue(3);  
            q.enqueue(4);
            q.enqueue(5);

            q.print();
            q.dequeue();
            q.dequeue();
            q.print();


            Console.ReadLine();

        }
    }
    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }

    class Stack
    {
        Node top;
        public Stack()
        {
            top = null;
        }

        public void push(int data) 
        {
            Node eleman= new Node(data);
            if(top==null)
            {
                top = eleman;
                Console.WriteLine("stack'e ilk eleman başarıyla eklendi.");
            }
            else
            {
                eleman.next = top;
                top = eleman;
                Console.WriteLine("stack'e eleman eklendi. ");
            }
        }
        public int pop()
        {
            
            if (top == null)
            {
                Console.WriteLine("stack boş!");
                return -1;
            }
            else
            {
                int sayı = top.data;
                top = top.next;

                return sayı;
            }
        }
        public void print()
        {
            if(top==null)
            {
                Console.WriteLine("stack boş!");
            }
            else
            {
                Node temp = top;
                while(temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp=temp.next;
                }
            }
        }
    }
}
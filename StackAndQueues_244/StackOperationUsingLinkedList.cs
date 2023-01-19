using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues_244
{
    internal class StackOperationUsingLinkedList
    {
        private Node top;

        public StackOperationUsingLinkedList()
        {
            this.top = null;
        }
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine($"{value} pushed to stack");
        }
        internal void Peak()
        {
            if (this.top == null)
            {
                Console.WriteLine("The stack is empty");
                return;
            }
            else
            {
                Console.WriteLine($"{this.top.data} is in the top of the stack");
            }
        }
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("The stack is Empty");
                return;
            }
            else
            {
                Console.WriteLine("Value Poped is : " + this.top.data);
            }
            this.top = this.top.next;
        }
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                Peak();
                Pop();
            }
        }
        public void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Stack is Emptay");
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues_244
{
    internal class QueuesOperationUsingLinkedList
    {
        Node head = null;

        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;


            }
            Console.WriteLine("{0} inserted into queue ", node.data);

        }
        internal void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("The Queue is Emptay");
            }
            else
            {
                head = head.next;

            }
        }
        public void DisplayQueue()
        {
            if (head == null)
            {
                Console.WriteLine("The Queue is Empty");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }


    }
}

using System;

namespace _001_REVERSE_LINKEDLIST
{
    class Program
    {
        static void Main(string[] args)
        {

            Node head = new Node(1);
            //pointing
            head.next = new Node(2);
            head.next.next = new Node(3);
            head.next.next.next = new Node(4);
            head.next.next.next.next = new Node(5);

            Node currentNode = head;

            while (currentNode != null)
            {
                System.Console.WriteLine(currentNode.value + ",");
                currentNode = currentNode.next;
            }

        }
    }
}

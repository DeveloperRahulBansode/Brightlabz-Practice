using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSomeProgram
{
    internal class LinkedList
    {

        public class Node
        {
            public int data;
            public Node next;


            public Node(int data)
            {
                this.data = data;
                next = null;

            }
        }

        //add node at the Head of the list
        Node head;
        public void addHead(int data)
        {

            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            newNode.next = head;
            head = newNode;


        }
        public void addlast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node cutrrentNode = head;
            while (cutrrentNode.next != null)
            {
                cutrrentNode = cutrrentNode.next;
            }
            cutrrentNode.next = newNode;
        }

        public void printList()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node currentNode = head;
            while (currentNode != null)
            {
                Console.Write(currentNode.data + "->");
                currentNode = currentNode.next;
            }
            Console.WriteLine("Null");
        }
        public void deleteNode(int data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            if (head.data == data)
            {
                head = head.next;
                return;
            }
            Node currentNode = head;
            while (currentNode.next != null)
            {
                if (currentNode.next.data == data)
                {
                    currentNode.next = currentNode.next.next;
                    return;
                }
                currentNode = currentNode.next;
            }
            Console.WriteLine("Data not found");
        }
        public void updateNode(int oldData, int newData)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Node currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.data == oldData)
                {
                    currentNode.data = newData;
                    return;
                }
                currentNode = currentNode.next;
            }
            Console.WriteLine("Data not found");
        }
       

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions
{
    public class SingleLinkList
    {

        public class Node
        {
            public string data;
            public Node next;

            public Node(string data)
            {
                this.data = data;
                next = null;
            }
        }
        Node head;

        public void addfirst(string data)
        {
            Node newNode = new(data);
            if (head == null)
            {
                head = newNode;
                return;

            }
            newNode.next = head;
            head = newNode;

        }
        //last 
        public void addLast(string data)
        {
            Node newNode = new(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node currenode = head;
            while (currenode.next != null)
            {
                currenode = currenode.next;
            }
            currenode.next = newNode;
        }
        public void printList()
        {

            if (head == null)
            {
                Console.WriteLine("LinkList Is Empty");
                return;
            }
            Node currNode = head;
            while (currNode.next !=null)
            {
                Console.Write(currNode.data +"->");
                currNode = currNode.next;
            }
            Console.Write("null");
        }
       
        
        



    }







    
}

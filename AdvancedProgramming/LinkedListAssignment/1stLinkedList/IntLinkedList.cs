/* Lily Ayala
 * PROG 260
 * Instructor: Kurt Friedrich
 * HW3 - LinkedList
 * Date: April 23rd 2018
 * 
  */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stLinkedList
{
    public class IntLinkedList
    {
        //*********************************************************************************************
        // define our Nested Class, a class that defines the objects that are in the linked lists
        // could be private, but when you get into testing methodology, many times you will want child versions to use for testing.
        protected class LinkedListNode
        {
            public int node_data;  // Property holds the "data", this could be a complex object, like a Customer object
            public LinkedListNode node_next_pointer;  // Property holds the "pointer" (actually a node with a pointer in it)  to the next node in the list

            // constructor: call it to create and set value of data, note the node_next_pointer property is set to null by default      
            public LinkedListNode(int value)
            {
                node_data = value;

            }
        }


        public bool RemoveByValue(int target)
        {
            // deal with condition if list is empty

            if(frontOfList == null)
            {
                throw new ArgumentOutOfRangeException("The list is empty");
            }

            bool removed = false; // create a current “reference” variable

            // if value is found in the first entry, 
            //change the frontOfList contents to effectively remove that node, and return true, for success
            LinkedListNode current = this.frontOfList;
            LinkedListNode prev = null;

            // do a while loop, where it exits if the current node’s pointer 
            //to the next node sees that the next node is null, which indicates we are at bottom of list

            int index = 101;
            while (index < target && current != null)
            {
                prev = current;
                current = current.node_next_pointer;

                index++;
            }

            if (current != null)
            {
                if (prev == null)
                {
                    this.frontOfList = current.node_next_pointer;
                }
                else
                {
                    prev.node_next_pointer = current.node_next_pointer;
                    current = null;
                }

                current = null;
                removed = true;  // return true  (found it)

            }

            return removed;
        }

        public void Print()
        {
            LinkedListNode cur = frontOfList;     // 1.Setup
            while (cur != null)                   // 2.Iteration Logic
            {
                Console.WriteLine(cur.node_data); // 3.Work (done at each iteration)
                cur = cur.node_next_pointer;      // 2.Iteration Logic
            }
            // 4.Teardown (anything that happens after the iteration)
        }


        public bool Find(int target)
        {
            LinkedListNode cur = frontOfList;                         // 1.Setup
            while (cur != null) //if list empty, or at end of list: done 2.Iteration Logic
            {
                if (cur.node_data == target)                          // 3.Work 
                {
                    return true;                                     // 4. Tear down
                }
                cur = cur.node_next_pointer;                    // 2.Iteration Logic
            }
            return false;                                           // 4. Tear down
        }

        //*********************************************************************************************

        // now define the IntLinkedList Class

        // the only data item the class has is the pointer (actually a node with a pointer in it) to the first item in the list 

        protected LinkedListNode frontOfList; // No constructor, but an undefined object has the value null; which is our flag that the list is empty

        // Method to add a node to the front of the list:
        public void InsertAtFront(int value)
        {
            LinkedListNode newNode = new LinkedListNode(value);  // create a new node
            newNode.node_next_pointer = frontOfList; // make this new first node point to what was just the first node;
            // if the List had been empty, then we just made the newNode point to "null", which says there is no 2nd node.
            frontOfList = newNode; // change the "reference" to front of list to point to this new one, which itself now points to the prior front of list
            // we are dealing with this frontOfList because this method specifically says to add to the front.  Later we will insert into other places.
        }

        // Method to remove the node from the front of the list
        public int RemoveFromFront()  // returns the "value" that the list object stores, in this case, an int
        {
            int returnVal; 
            if (frontOfList == null)
            {
                throw new IndexOutOfRangeException("list is empty");
            }
            else
            {
                returnVal = frontOfList.node_data; // get the data from the node at the front of the list
                frontOfList = frontOfList.node_next_pointer;  // copy the front of list's node's pointer to the next node, into the front of List
                // if there was not another node, we just copied a null into the pointer, which says the list is now empty
            }
            return returnVal;
        }


        internal int Get4thNode()
        {
            int x;
            LinkedListNode current = new LinkedListNode(0);
            current = frontOfList;
             //x = current.node_data;              
            // x = current.node_next_pointer.node_data;         //2nd node's data
            // x = current.node_next_pointer.node_next_pointer.node_data;      //3rd node's data
            x = current.node_next_pointer.node_next_pointer.node_next_pointer.node_data;      //4th node's data
            return x;

        }

      
    }
}
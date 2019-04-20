using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            IntLinkedList MyLinkedList = new IntLinkedList();

            MyLinkedList.InsertAtFront(101);

            MyLinkedList.InsertAtFront(102);

            MyLinkedList.InsertAtFront(103);

            MyLinkedList.InsertAtFront(104);

            MyLinkedList.InsertAtFront(105);

            Console.WriteLine(value: "should be 105  " + MyLinkedList.RemoveByValue(105));

            Console.WriteLine(value: "should be 101  " + MyLinkedList.RemoveByValue(101));

            Console.WriteLine(value: "should be 103  " + MyLinkedList.RemoveByValue(103));

            Console.WriteLine();

            MyLinkedList.Print();

            Console.ReadLine();
        }
    }
}

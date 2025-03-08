using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Reverser<T>
    {
        // Method to reverse a doubly linked list
        public static Node<T> Reverse(Node<T> head)
        {
            // If the list is empty or has only one node,
            // return the head as is
            if (head == null || head.Next == null)
                return head;
            Node<T> prevNode = null;
            Node<T> currNode = head;
            // Traverse the list and reverse the links
            while (currNode != null)
            {
                // Swap the next and prev pointers
                prevNode = currNode.Prev;
                currNode.Prev = currNode.Next;
                currNode.Next = prevNode;
                // Move to the next node in the original list
                // (which is now previous due to reversal)
                currNode = currNode.Prev;
            }
            // The final node in the original list
            // becomes the new head after reversal
            head = prevNode.Prev;
            return head;
        }
    }
}

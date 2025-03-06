using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Reverser<T>
    {
        // Function to get the middle of the linked list
        public static T GetMiddle(Node<T>? head)
        {
            // Initialize the slow and fast pointer to the head
            // of the linked list
            Node<T>? slow_ptr = head;
            Node<T>? fast_ptr = head;
            while (fast_ptr != null && fast_ptr.Next != null)
            {
                // Move the fast pointer by two nodes
                fast_ptr = fast_ptr.Next.Next;
                // Move the slow pointer by one node
                slow_ptr = slow_ptr.Next;
            }
            // Return the slow pointer which is currently
            // pointing to the middle node of the linked list
            return slow_ptr.Data;
        }
    }
}

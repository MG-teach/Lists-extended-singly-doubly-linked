namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a doubly linked list:
            // 1 <-> 2 <-> 3 <-> 4
            
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

            list.AddFirst(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);

            Node<int> head = list.Head;

            Console.WriteLine("Original Doubly Linked List");
            PrintList(head);
            head = Reverser<int>.Reverse(head);
            Console.WriteLine("Reversed Doubly Linked List");
            PrintList(head); ;
        }

        static void PrintList<T>(Node<T> node)
        {
            while (node != null)
            {
                Console.Write(node.Data + " ");
                node = node.Next;
            }
            Console.WriteLine();
        }
    }
}

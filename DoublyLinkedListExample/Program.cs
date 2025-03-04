namespace DoublyLinkedListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

            list.AddFirst(10);
            list.AddFirst(20);
            list.AddLast(30);
            list.PrintList();

            Console.WriteLine("Премахнат елемент от началото: " + list.RemoveFirst());
            list.PrintList();

            Console.WriteLine("Премахнат елемент от края: " + list.RemoveLast());
            list.PrintList();

            Console.WriteLine("Списъкът съдържа 10: " + list.Contains(10));
            Console.WriteLine("Списъкът е празен: " + list.IsEmpty());
        }
    }
}

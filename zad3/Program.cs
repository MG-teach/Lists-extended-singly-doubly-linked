namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 42, 7, 19, 3, 88, 56 };
            LinkedList<int> linkedList = new LinkedList<int>();

            foreach (var value in array)
            {
                linkedList.AddLast(value);
            }

            Console.WriteLine("Problem 1:");
            Console.WriteLine("Original Linked List:");
            PrintList(linkedList);
            Console.WriteLine();

            Console.WriteLine("Sorted Linked List:");
            PrintList(Sorter.MergeSort(linkedList));
            Console.WriteLine();

            Console.WriteLine("Problem 2:");
            int number1 = 19;
            int number2 = 100;

            Console.WriteLine(Searcher.SearchNumber(linkedList, number1) 
                ? $"Number {number1} is in the list!" : $"Number {number1} is not in the list!");
            Console.WriteLine(Searcher.SearchNumber(linkedList, number2)
                ? $"Number {number2} is in the list!" : $"Number {number2} is not in the list!");
        }

        static void PrintList(LinkedList<int> linkedList)
        {
            foreach (var value in linkedList)
            {
                Console.Write(value);
                if (value != linkedList.Last.Value)
                    Console.Write(" <-> ");
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}

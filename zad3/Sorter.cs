using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Sorter
    {
        public static LinkedList<int> MergeSort(LinkedList<int> linkedList)
        {
            if (linkedList.Count <= 1) return linkedList;

            // Split the list into two halves
            var (left, right) = Split(linkedList);

            // Recursively sort each half
            left = MergeSort(left);
            right = MergeSort(right);

            // Merge the sorted halves
            return Merge(left, right);
        }

        static (LinkedList<int>, LinkedList<int>) Split(LinkedList<int> list)
        {
            LinkedList<int> left = new LinkedList<int>();
            LinkedList<int> right = new LinkedList<int>();

            int middle = list.Count / 2;
            int index = 0;

            foreach (var value in list)
            {
                if (index < middle) left.AddLast(value);
                else right.AddLast(value);
                index++;
            }

            return (left, right);
        }

        static LinkedList<int> Merge(LinkedList<int> left, LinkedList<int> right)
        {
            LinkedList<int> result = new LinkedList<int>();
            var leftNode = left.First;
            var rightNode = right.First;

            while (leftNode != null && rightNode != null)
            {
                if (leftNode.Value < rightNode.Value)
                {
                    result.AddLast(leftNode.Value);
                    leftNode = leftNode.Next;
                }
                else
                {
                    result.AddLast(rightNode.Value);
                    rightNode = rightNode.Next;
                }
            }

            // Add remaining nodes
            while (leftNode != null)
            {
                result.AddLast(leftNode.Value);
                leftNode = leftNode.Next;
            }

            while (rightNode != null)
            {
                result.AddLast(rightNode.Value);
                rightNode = rightNode.Next;
            }

            return result;
        }
    }
}

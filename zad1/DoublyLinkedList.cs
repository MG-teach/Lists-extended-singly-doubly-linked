using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class DoublyLinkedList<T>
    {
        private Node<T> head; // Начален (първи) възел в списъка
        private Node<T> tail; // Краен (последен) възел в списъка

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
        }

        public Node<T> Head => head;

        public Node<T> Tail => tail;

        // Добавяне на елемент в началото на списъка
        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null) // Ако списъкът е празен
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }
        }

        // Премахване на елемент от началото на списъка
        public T RemoveFirst()
        {
            if (head == null)
                throw new InvalidOperationException("Списъкът е празен");

            T removedData = head.Data; // Запазване на премахнатите данни
            head = head.Next; // Пренасочване на главата към следващия възел

            if (head != null)
                head.Prev = null;
            else
                tail = null; // Ако списъкът стане празен

            return removedData;
        }

        // Търсене на елемент по стойност
        public bool Contains(T value)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(value))
                    return true;
                current = current.Next;
            }
            return false;
        }

        // Проверка дали списъкът е празен
        public bool IsEmpty()
        {
            return head == null;
        }

        // Добавяне на елемент в края на списъка
        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (tail == null) // Ако списъкът е празен
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
        }

        // Премахване на елемент от края на списъка
        public T RemoveLast()
        {
            if (tail == null)
                throw new InvalidOperationException("Списъкът е празен");

            T removedData = tail.Data; // Запазване на премахнатите данни
            tail = tail.Prev; // Пренасочване на опашката към предходния възел

            if (tail != null)
                tail.Next = null;
            else
                head = null; // Ако списъкът стане празен

            return removedData;
        }

        public void PrintList()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write(current.Data + " <-> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}


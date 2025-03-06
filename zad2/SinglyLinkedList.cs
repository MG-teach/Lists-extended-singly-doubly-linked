using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class SinglyLinkedList<T>
    {
        private Node<T>? head; // Първи елемент (глава) на списъка
        private Node<T>? tail;

        public SinglyLinkedList()
        {
            head = null;
            tail = null;
        }

        // Добавяне на елемент в началото на списъка
        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if(head == null)
            {
                head = newNode;
                tail = newNode;
            }
            newNode.Next = head; // Новият възел сочи към стария първи елемент
            head = newNode; // Главата сочи към новия възел
        }

        // Премахване на елемент от началото на списъка
        public T RemoveFirst()
        {
            if (head == null)
                throw new InvalidOperationException("Списъкът е празен");

            T removedData = head.Data; // Запазване на премахнатите данни
            head = head.Next; // Главата сочи към следващия възел
            return removedData;
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }

        public T RemoveLast()
        {
            if (head == null)
                throw new InvalidOperationException("Списъкът е празен");

            if (head == tail)
            {
                T data = head.Data;
                head = null;
                tail = null;
                return data;
            }

            Node<T>? current = head;
            while (current.Next != tail)
            {
                current = current.Next;
            }

            T removedData = tail.Data;
            tail = current;
            tail.Next = null;
            return removedData;
        }


        // Търсене на елемент по стойност
        public bool Contains(T value)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(value)) // Проверка дали текущият възел съдържа търсената стойност
                    return true;
                current = current.Next; // Преминаване към следващия възел
            }
            return false;
        }

        // Проверка дали списъкът е празен
        public bool IsEmpty()
        {
            return head == null;
        }

        public void PrintList()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedStack
{
    public class Node<T>
    {
        public T item;
        public Node<T> next;

        public Node(T item)
        {
            this.item = item;
        }

    }
    public class Stack<T>
    {
        public Node<T> stackTop;
        int count;
        public Stack()
        {
            stackTop = null;
            count = 0;
        }

        public void Push(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (newNode == null)
            {
                throw new InvalidOperationException("Stack push cannot alloctae memory");
            }
            newNode.next = stackTop;
            stackTop = newNode;
            count++;
        }

        public void Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");

            Node<T> temp = stackTop;
            stackTop = stackTop.next;
            temp.next = null;
            count--;


        }

        public T PopTop()
        {

            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");

            T top = stackTop.item;
            Node<T> temp = stackTop;
            stackTop = stackTop.next;
            temp.next = null;

            count--;
            return top;

        }
        public T getTop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");

            }

            return stackTop.item;
        }

        public bool IsEmpty()
        {
            return stackTop == null;
        }

        public void Display()
        {
            Node<T> current = stackTop;

            while (current != null)
            {
                Console.WriteLine(current.item);
                current = current.next;
            }
        }
        public int Count()
        {
            return count;
        }


    }
}

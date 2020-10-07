using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExampleJMC
{
    public class SList<E>
    {
        private SNode<E> head, tail;
        private int size;

        public SList()
        {
            head = null;
            tail = null;
        }

        public int Size()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size <= 0;
        }

        public E First()
        {
            if (IsEmpty())
            {
                throw new EmptyListException();
            }
            return head.Element;
        }

        public E Last()
        {
            if (IsEmpty())
            {
                throw new EmptyListException();
            }
            return tail.Element;
        }

        public void AddFirst(E element)
        {
            SNode<E> newest = new SNode<E>(element, head);
            head = newest;
            if (IsEmpty())
            {
                tail = newest;
            }
            size++;
        }

        public void AddLast(E element)
        {
            SNode<E> newest = new SNode<E>(element, null);
            tail.Next = newest;
            tail = newest;
            if (IsEmpty())
            {
                head = newest;
            }
            size++;
        }

        public E RemoveFirst()
        {
            SNode<E> temp = head;
            head = temp.Next;
            temp.Next = null;
            E tempElement = temp.Element;
            temp.Element = default;
            size--;
            return tempElement;
        }
    }
}

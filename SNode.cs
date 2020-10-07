using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExampleJMC
{
    public class SNode<E>
    {
        private E element;
        private SNode<E> next;

        public SNode(E element, SNode<E> next)
        {
            Element = element;
            Next = next;
        }

        public E Element
        {
            get { return element; }
            set { element = value; }
        }
        public SNode<E> Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}

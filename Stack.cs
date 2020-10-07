using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface Stack<E>
    {
        void Push(E e);
        E Pop();

        E Top();
        int Size();
        bool IsEmpty();

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GenericStack
{
    class Stack<T>
    {
        T[] elements;
        int index;

        public Stack(int maxElementCount = 100)
        {
            elements = new T[maxElementCount];
            index = -1;
        }
    }


}

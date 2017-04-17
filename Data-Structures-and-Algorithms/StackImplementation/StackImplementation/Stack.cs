using System;

namespace StackImplementation
{
    public class Stack<T>
    {
        private T[] stack;
        private int nextFreeStackIndex;

        public Stack(int stackSize)
        {
            if (stackSize < 0)
            {
                throw new ArgumentOutOfRangeException("Size of the stack must be greater than 0");
            }
            stack = new T[stackSize];
            nextFreeStackIndex = 0;
        }

        public void Push(T value)
        {
            if (nextFreeStackIndex == stack.Length)
            {
                Array.Resize(ref stack, stack.Length < 100 ? 2 * stack.Length : (int)(stack.Length * 1.2));
            }

            stack[nextFreeStackIndex++] = value;
        }

        public T Pop()
        {
            if (nextFreeStackIndex == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            T elementToPop = stack[--nextFreeStackIndex];

            return elementToPop;
        }
    }
}

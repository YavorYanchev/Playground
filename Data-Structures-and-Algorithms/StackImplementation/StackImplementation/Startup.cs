using System;

namespace StackImplementation
{
    public class Startup
    {
        public static void Main()
        {
            var myStack = new Stack<int>(5);
            myStack.Push(1);
            myStack.Push(2);
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
        }
    }
}

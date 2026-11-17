namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack64U stack = new Stack64U();

            Console.WriteLine("Pushing 1,2,3,4,5,6 to stack");
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            Console.WriteLine("Elements in stack: {0}",stack.GetSize());
            if (stack.StackIsEmpty())
                Console.WriteLine("Stack is empty.");
            else
                Console.WriteLine("Stack is not empty");

            Console.WriteLine("Pushing 7,8,9 to stack");
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            Console.WriteLine("Elements in stack: {0}", stack.GetSize());

            ulong? peekedElement = stack.Peek();    // Testing Peek

            if (peekedElement == null)
                Console.WriteLine("Stack is empty");
            else
                Console.WriteLine("\nPeeked element: {0}\n", peekedElement);

            Console.WriteLine("Pushing 10 to stack");
            stack.Push(10);
            Console.WriteLine("Elements in stack: {0}", stack.GetSize());

            Console.WriteLine("Popping all elements in stack");
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Console.WriteLine("Elements in stack: {0}", stack.GetSize());

            peekedElement = stack.Peek(); // Testing peek when stack is empty

            if (peekedElement == null)
                Console.WriteLine("Stack is empty");
            else
                Console.WriteLine("\nPeeked element: {0}\n", peekedElement);

            stack.Push(1);
            stack.Pop();

            Console.WriteLine("Pushing 5,3,7,2 to stack");
            stack.Push(5);      // Testing getMinValue
            stack.Push(3);
            stack.Push(7);
            stack.Push(2);

            Console.WriteLine("\nSmallest element: {0}\n", stack.GetMinValue());    // 2
            Console.WriteLine("Popping 2");

            stack.Pop();
            Console.WriteLine("\nSmallest element: {0}\n", stack.GetMinValue()); // 3
            Console.WriteLine("Popping 7");

            stack.Pop();
            Console.WriteLine("\nSmallest element: {0}\n", stack.GetMinValue()); // 3
            Console.WriteLine("Popping 3");

            stack.Pop();
            Console.WriteLine("\nSmallest element: {0}\n", stack.GetMinValue());    // 5
            Console.WriteLine("Popping 5");
            stack.Pop();
        }
    }
}
namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack64U stack = new Stack64U();
            StackList stack = new StackList();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            Console.WriteLine(stack.GetSize());
            Console.WriteLine(stack.StackIsEmpty());

            stack.Push(7);
            stack.Push(8);
            stack.Push(9);

            ulong? peekedElement = stack.Peek();    // Testing Peek

            if (peekedElement == null)
                Console.WriteLine("Stack is empty");
            else
                Console.WriteLine("\nPeeked element: {0}\n", peekedElement);

            stack.Push(10);

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

            peekedElement = stack.Peek(); // Testing peek when stack is empty

            if (peekedElement == null)
                Console.WriteLine("Stack is empty");
            else
                Console.WriteLine("\nPeeked element: {0}\n", peekedElement);

            stack.Push(1);
            stack.Pop();

            stack.Push(5);      // Testing getMinValue
            stack.Push(3);
            stack.Push(7);
            stack.Push(2);

            Console.WriteLine("\nSmallest element: {0}\n", stack.GetMinValue()); // 2

            stack.Pop();
            Console.WriteLine("\nSmallest element: {0}\n", stack.GetMinValue()); // 3

            stack.Pop();
            Console.WriteLine("\nSmallest element: {0}\n", stack.GetMinValue()); // 3

            stack.Pop();
            Console.WriteLine("\nSmallest element: {0}\n", stack.GetMinValue());    // 5

            stack.Pop();
        }
    }
}
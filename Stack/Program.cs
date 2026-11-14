namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack64U stack = new Stack64U();

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

    class testPrint
    {
        string st;

        public testPrint(string s)
        {
            st = s;
        }

        public void print()
        {
            Console.WriteLine(st);
        }
    }

    class Stack64U
    {
        // Variables in the class:
        int index;
        int size;
        int capacity;
        ulong[] stack;
        ulong[] minStack;

        // Initializes the variables:
        public Stack64U()
        {
            index = -1;
            size = 0;
            capacity = 1;
            stack = new ulong[capacity];
            minStack = new ulong[capacity];     // Seperate stack that keeps track of smallest value
        }

        // Hidden method to check if the capacity of the array needs to be rezised:
        void CheckSize()
        {
            if (size == capacity)   // If the size = the capacity, the capacity is dubbled
            {
                capacity *= 2;
                Array.Resize(ref stack, capacity);
                Array.Resize(ref minStack, capacity);
                return;
            }
            if (capacity / 2 != 0 && size == capacity / 2)  // If the size = half the capacity, the capacity is halfed. Except if capacity/2 = 0, then nothing happens
            {
                capacity /= 2;
                Array.Resize(ref stack, capacity);
                Array.Resize(ref minStack, capacity);
                return;
            }
        }

        // Public method for pushing elements to the stack:
        public void Push(ulong element)
        {
            index++;    // Increases the index by 1
            stack[index] = element;     // Adds the element at the index
            if (size == 0)              // Sets the initial element as the smallest, or other things if it's not the initial element
                minStack[index] = element;
            else if(element < minStack[index - 1])
                minStack[index] = element;
            else
                minStack[index] = minStack[index - 1]; 
            size++;     // Increases the size by 1
            CheckSize();    // Checks need of resizing

            // Controll loop:
            for (int i = 0; i < capacity; i++)
            {
                Console.WriteLine(stack[i]);
            }
            Console.WriteLine("");
        }

        // Public method for popping the last element out of the stack:
        public void Pop()
        {
            if (size == 0)
                throw new Exception("The stack is empty");
            
            stack[index] = 0;   // Sets the popped element to 0
            minStack[index] = 0; // Sets the popped element to 0 in the minStack
            index--;
            size--;
            CheckSize();

            // Controll loop:
            for (int i = 0; i < capacity; i++)
            {
                Console.WriteLine(stack[i]);
            }
            Console.WriteLine("");
        }

        // Public method for peeking the element at the top of the stack
        public ulong? Peek()
        {
            if(StackIsEmpty())
                return null;
            
            else
                return stack[index];
        }

        // Public method that keeps track of and retrieves smallest value
        public ulong GetMinValue()
        {
            if(size == 0)
                throw new Exception("The stack is empty");
            return minStack[index];
        }
        public int GetSize()
        {
            return size;
        }

        public bool StackIsEmpty()
        {
            if (size == 0)
                return true;

            return false;
        }
    }
}
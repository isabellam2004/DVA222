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

            Console.WriteLine(stack.StackIsEmpty());

            stack.Push(1);
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

        // Initializes the variables:
        public Stack64U()
        {
            index = -1;
            size = 0;
            capacity = 1;
            stack = new ulong[capacity];
        }

        // Hidden method to check if the capacity of the array needs to be rezised:
        void CheckSize()
        {
            if (size == capacity)
            {
                capacity *= 2;
                Array.Resize(ref stack, capacity);
                return;
            }
            if (capacity / 2 != 0 && size == capacity / 2)
            {
                capacity /= 2;
                Array.Resize(ref stack, capacity);
                return;
            }
        }

        // Public method for pushing elements to the stack:
        public void Push(ulong element)
        {
            index++;    // Increases the index by 1
            stack[index] = element;     // Adds the element at the index
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
            stack[index] = 0;   // Sets the popped element to 0
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
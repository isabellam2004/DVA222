namespace Stack
{
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
            minStack = new ulong[capacity];     // Array that keeps track of smallest value
        }

        // Public method for pushing elements to the stack:
        public void Push(ulong element)
        {
            if (size == capacity)   // If the size = the capacity, the cap  acity is dubbled
            {
                capacity *= 2;
                Array.Resize(ref stack, capacity);
                Array.Resize(ref minStack, capacity);
            }

            index++;    // Increases the index by 1
            stack[index] = element;     // Adds the element at the index
            if (size == 0)              // Sets the initial element as the smallest, or other things if it's not the initial element
                minStack[index] = element;
            else if (element < minStack[index - 1])
                minStack[index] = element;
            else
                minStack[index] = minStack[index - 1];
            size++;     // Increases the size by 1
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

            if (capacity / 2 != 0 && size == capacity / 2)  // If the size = half the capacity, the capacity is halfed. Except if capacity/2 = 0, then nothing happens
            {
                capacity /= 2;
                Array.Resize(ref stack, capacity);
                Array.Resize(ref minStack, capacity);
            }
        }

        // Public method for peeking the element at the top of the stack
        public ulong? Peek()
        {
            if (StackIsEmpty())
                return null;

            else
                return stack[index];
        }

        // Public method that keeps track of and retrieves smallest value
        public ulong GetMinValue()
        {
            if (size == 0)
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

namespace Stack
{
    class StackList
    {
        List<ulong> stack;
        List<ulong> minHistory;
        ulong minValue;

        public StackList()
        { 
            stack = new List<ulong>();
            minHistory = new List<ulong>();
            minValue = ulong.MaxValue;  // Initially the max value of ulong
        }

        public void Push(ulong element)
        {
            stack.Add(element);

            if (element < minValue)     // If the added element is less than the minValue, the minValue is set to the element
                minValue = element;
            minHistory.Add(minValue);   // The current minValue is added to the history list
        }

        public ulong Pop()
        {
            if (stack.Count == 0)
                throw new Exception("Stack is empty");

            ulong popped_value = stack[stack.Count - 1];
            
            stack.RemoveAt(stack.Count - 1);    // Removes the last element of the list
            minHistory.RemoveAt(minHistory.Count - 1);      // Removes the most recent reccorded min value
            if (minHistory.Count == 0)  // If the history list is empty the minValue resets to its initially value
                minValue = ulong.MaxValue;
            else
                minValue = minHistory[minHistory.Count - 1];    // Else the minValue is set to the now most recent reccorded min value

            if (popped_value == 0)
                throw new Exception("Stack is empty");
            else
                return popped_value;
        }

        public ulong? Peek()
        {
            if (stack.Count == 0)   // If the stack is empty null is returned
                return null;
            return stack[stack.Count - 1];  // Else the last element of the list is returned
        }

        public ulong GetMinValue()
        {
            if (stack.Count == 0)   // If you try to get a min value from an empty stack, an exception is thrown which tells you that the stack is empty
                throw new Exception("The stack is empty");
            return minValue;
        }

        public int GetSize()
        {
            return stack.Count;
        }

        public bool StackIsEmpty()
        {
            if (stack.Count == 0)
                return true;
            return false;
        }
    }
}

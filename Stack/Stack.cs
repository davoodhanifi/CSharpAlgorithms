namespace Stack
{
    public class Stack
    {
        private int _maxSize;
        private string[] _stackArray;
        private int top;

        public Stack(int maxSize)
        {
            this._maxSize = maxSize;
            this._stackArray = new string[_maxSize];
            this.top = -1;
        }

        public void Push(string item)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is already full.");
            }
            else
            {
                _stackArray[++top] = item;
            }
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                return string.Empty;
            }
            else
            {
                return _stackArray[top--];
            }
        }

        public string Peek()
        {
            return _stackArray[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
          return _maxSize - 1 == top;
        }
    }
}

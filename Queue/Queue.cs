namespace Queue
{
    public class Queue
    {
        private int _maxSize;
        private long[] _queue;
        private int _front;
        private int _rear;
        private int _itemsCount;

        public Queue(int size)
        {
            this._maxSize = size;
            this._queue = new long[size];
            this._front = 0;
            this._rear = -1;
            this._itemsCount = 0;
        }

        public void Enqueue(long item)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is already full.");
            }
            else
            {
                if (_rear == _maxSize - 1)
                {
                    _rear = -1;
                }

                _queue[++_rear] = item;
                _itemsCount++;
            }
        }

        public long Dequeue()
        {
            var item = _queue[_front];
            if (IsEmpty())
            {
                Console.WriteLine("Queue is already empty.");
            }
           
            _front++;
            if (_front == _maxSize)
            {
                _front = 0;
            }

            return item;
        }

        public long Peek()
        {
            return _queue[_front];
        }

        public bool IsEmpty()
        {
            return _itemsCount == 0;
        }

        public bool IsFull()
        {
            return _itemsCount == _maxSize;
        }

        public void View()
        {
            Console.Write("[ ");
            for (int i = 0; i < _queue.Length; i++)
            {
                Console.Write($"{_queue[i]} ");
            }
            Console.WriteLine("]");
        }
    }
}

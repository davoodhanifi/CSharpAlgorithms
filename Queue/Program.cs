
Queue.Queue myQueue = new(5);
myQueue.Enqueue(100);
myQueue.Enqueue(10);
myQueue.Enqueue(20);
myQueue.Enqueue(30);
myQueue.Enqueue(40);
myQueue.View();

Console.WriteLine($"Front of queue is {myQueue.Peek()} ");

Console.WriteLine("About to remove item from queue");
myQueue.Dequeue();
Console.WriteLine($"Front of queue is {myQueue.Peek()} ");
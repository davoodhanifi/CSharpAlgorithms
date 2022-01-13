using Stack;

Stack.Stack theStack = new(4);
theStack.Push("Star Wars");
theStack.Push("Jaws");
theStack.Push("Jaws 2");
theStack.Push("Titanic");
theStack.Push("Rocky");

Console.WriteLine("================== \nAbout to peek:");
Console.WriteLine($"'{ theStack.Peek() }'" + " is at the top of the stack.\n");

Console.WriteLine("================== \nThe Stack contains:\n");
while (!theStack.IsEmpty())
{
    string movie = theStack.Pop();
    Console.WriteLine(movie);
}
int theValue = 43;
int[] array = new int[] { 11, 22, 43, 54, 57, 59, 62, 78 };
BinarySearch.BinarySearch binarySearcher = new();

Console.WriteLine("Our array contains: ");
Array.ForEach(array, x => Console.Write(x + " "));

Console.Write($"\n\nThe result of a binary search for {theValue} is: ");
Console.WriteLine(binarySearcher.Search(array, theValue));
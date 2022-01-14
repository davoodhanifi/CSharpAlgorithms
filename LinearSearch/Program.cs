var theValue = 7;
int[] array = new[] { 1, 4, 5, 7, 10, 15, 20 };
LinearSearch.LinearSearch linearSearcher = new();

Console.WriteLine("Our array contains: ");
Array.ForEach(array, x => Console.Write($"{x} "));

Console.Write($"\n\nThe result of a binary search for {theValue} is: ");
Console.WriteLine(linearSearcher.Search(array, theValue));
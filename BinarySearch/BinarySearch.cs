namespace BinarySearch
{
    public class BinarySearch
    {
        public int Search(int[] array, int item)
        {
            var firstPoint = 0;
            var lastPoint = array.Length - 1;

            while (firstPoint <= lastPoint)
            {
                var midPoint = (firstPoint + lastPoint) / 2;

                if (item < array[midPoint])
                    lastPoint = midPoint - 1;
                else if (item > array[midPoint])
                    firstPoint = midPoint + 1;
                else
                    return midPoint;
            }

            return -1;
        }
    }
}

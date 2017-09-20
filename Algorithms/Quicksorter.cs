namespace Algorithms
{
    using System;
    using System.Collections.Generic;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            int left = 0;
            int right = collection.Count - 1;
            InternalQuickSort(collection, left, right);
        }

        private static void InternalQuickSort(IList<T> collection, int left, int right)
        {
            int originalLeft = left;
            int originalRight = right;
            T pivot = collection[(left + right) / 2];

            while (left < right)
            {
                while (collection[left].CompareTo(pivot) < 0)
                {
                    left++;
                }
                while (collection[right].CompareTo(pivot) > 0)
                {
                    right--;
                }
                if (left <= right)
                {
                    //swap
                    T temp = collection[left];
                    collection[left] = collection[right];
                    collection[right] = temp;

                    left++;
                    right--;
                }
            }

            //recursive calls
            if (originalLeft < right)
            {
                InternalQuickSort(collection, originalLeft, right);
            }
            if (left < originalRight)
            {
                InternalQuickSort(collection, left, originalRight);
            }
            
            
        }
    }
}

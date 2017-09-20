namespace Algorithms
{
    using System;
    using System.Collections.Generic;

    public class BubbleSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            bool swapped = false;

            do
            {
                swapped = false;

                for (int i = 0; i < collection.Count - 1; i++)
                {
                    T first = collection[i];
                    T second = collection[i + 1];
                    int result = first.CompareTo(second);

                    if (first.CompareTo(second) > 0)
                    {
                        collection[i] = second;
                        collection[i + 1] = first;
                        swapped = true;
                    }
                }
            } while (swapped == true);
        }
    }
}

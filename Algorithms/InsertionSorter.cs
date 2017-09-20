namespace Algorithms
{
    using System;
    using System.Collections.Generic;

    public class InsertionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            for (int i = 1; i < collection.Count; i++)
            {
                T element = collection[i];

                for (int j = i - 1; j >= 0;)
                {
                    if (element.CompareTo(collection[j]) < 0)
                    {
                        collection[j + 1] = collection[j];
                        j--;
                        collection[j + 1] = element;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}

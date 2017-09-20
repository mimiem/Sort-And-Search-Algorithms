namespace Algorithms
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
                if (item.CompareTo(this.Items[i]) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool BinarySearch(T item)
        {
            T min = this.Items[0];
            T max = this.Items[this.Items.Count - 1];
            int mid = ((this.Items.Count - (this.Items.Count % 2)) / 2);

            while (max.CompareTo(min) >= 0)
            {
                if (this.Items[mid].CompareTo(item) > 0)
                {
                    max = this.Items[mid - 1];
                }
                else if (this.Items[mid].CompareTo(item) < 0)
                {
                    min = this.Items[mid + 1];
                }
                else
                {
                    return true;
                }
                mid++;
            }
            
            return false;
        }

        public void Shuffle()
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
                Random rdm = new Random();
                int r = i + rdm.Next(0, this.Items.Count - i);
                T temp = this.Items[i];
                this.Items[i] = this.Items[r];
                this.Items[r] = temp;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    internal class Heap<T> where T : IComparable
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;

        public Heap() { }
        public Heap(IEnumerable<T> items)
        {
            this.items.AddRange(items);

            for (int i = Count; i >= 0; i--)
            {
                Sort(i);
            }
        }

        public T Peek()
        {
            if (Count > 0)
                return items[0];
            else
                throw new ArgumentNullException(nameof(items), "The heap is empty");
        }

        public void Add(T data)
        {
            items.Add(data);

            var currentIndex = Count - 1;
            var parentIndex = GetParentIndex(currentIndex);

            while (currentIndex > 0 && items[parentIndex].CompareTo(items[currentIndex]) == 1)
            {
                Swap(currentIndex, parentIndex);

                currentIndex = parentIndex;
                parentIndex = GetParentIndex(currentIndex);
            }
        }

        public T GetMax()
        {
            var result = items[0];
            items[0] = items[Count - 1];
            items.RemoveAt(Count - 1);
            Sort(0);
            return result;
        }

        private void Sort(int currentIndex)
        {
            int maxIndex = currentIndex, leftIndex, rightIndex;

            while (currentIndex < Count)
            {
                leftIndex = 2 * currentIndex + 1;
                rightIndex = 2 * currentIndex + 2;

                if (leftIndex < Count && items[leftIndex].CompareTo(items[maxIndex]) == -1)
                    maxIndex = leftIndex;

                if (rightIndex < Count && items[rightIndex].CompareTo(items[maxIndex]) == -1)
                    maxIndex = rightIndex;

                if (maxIndex == currentIndex)
                    break;

                Swap(maxIndex, currentIndex);
                currentIndex = maxIndex;
            }
        }

        private void Swap(int currentIndex, int parentIndex)
        {
            var temp = items[currentIndex];
            items[currentIndex] = items[parentIndex];
            items[parentIndex] = temp;
        }

        private int GetParentIndex(int currentIndex)
        {
            return (currentIndex - 1) / 2;
        }

        public List<T> Order()
        {
            List<T> result = new List<T>();
            while(Count > 0)
            {
                result.Add(GetMax());
            }
            return result;
        }
    }
}

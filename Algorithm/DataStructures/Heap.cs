using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    public class Heap<T>: AlgorithmBase<T> where T : IComparable
    {
        private int Count => Items.Count;

        public Heap() { }
        public Heap(IEnumerable<T> items)
        {
            Items.AddRange(items);
            for (int i = Count; i >= 0; i--)
            {
                Sort(i);
            }
        }

        public void Add(T data)
        {
            Items.Add(data);

            var currentIndex = Count - 1;
            var parentIndex = GetParentIndex(currentIndex);

            while (currentIndex > 0 && Compare(Items[parentIndex], Items[currentIndex]) == -1)
            {
                Swap(currentIndex, parentIndex);

                currentIndex = parentIndex;
                parentIndex = GetParentIndex(currentIndex);
            }
        }

        public T GetMax()
        {
            var result = Items[0];
            Items[0] = Items[Count - 1];
            Items.RemoveAt(Count - 1);
            Sort(0);
            return result;
        }

        private void Sort(int currentIndex, int maxLength = -1)
        {
            int maxIndex = currentIndex, leftIndex, rightIndex;

            maxLength = maxLength == -1 ? Count : maxLength;

            while (currentIndex < maxLength)
            {
                leftIndex = 2 * currentIndex + 1;
                rightIndex = 2 * currentIndex + 2;

                if (leftIndex < maxLength && Compare(Items[leftIndex], Items[maxIndex]) == 1)
                    maxIndex = leftIndex;

                if (rightIndex < maxLength && Compare(Items[rightIndex], Items[maxIndex]) == 1)
                    maxIndex = rightIndex;

                if (maxIndex == currentIndex)
                    break;

                Swap(maxIndex, currentIndex);
                currentIndex = maxIndex;
            }
        }

        private int GetParentIndex(int currentIndex)
        {
            return (currentIndex - 1) / 2;
        }

        protected override void MakeSort()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                Swap(0,i);
                Sort(0,i);
            }
        }
    }
}

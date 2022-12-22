using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class InsertionSort<T> : AlgorithmBase<T> where T: IComparable
    {
        public InsertionSort(IEnumerable<T> items) : base(items) { }

        public InsertionSort() { }

        protected override void MakeSort()
        {
            for (int i = 1; i < Items.Count; i++)
            {
                var temp = Items[i];
                var j = i;

                while(j > 0 && Compare(temp, Items[j - 1]) == -1)
                {
                    Swap(j, j - 1);
                    j--;
                }
                Items[j] = temp;
            }
        }
    }
}

using System;

namespace Algorithm
{
    public class CoctailSort<T> : AlgorithmBase<T> where T: IComparable 
    {
        protected override void MakeSort()
        {
            int left = 0;
            int right = Items.Count - 1;

            while (left < right)
            {
                var sc = SwapCount;
                for (int i = left; i < right; i++)
                {
                    var a = Items[i];
                    var b = Items[i + 1];

                    if (a.CompareTo(b) == 1)
                    {
                        Swap(i, i + 1);
                        ComparisonCount++;
                    }
                }
                right--;

                if (sc == SwapCount) break;

                for (int i = right; i > left; i--)
                {
                    var a = Items[i];
                    var b = Items[i - 1];

                    if (a.CompareTo(b) == -1)
                    {
                        Swap(i, i - 1);
                        ComparisonCount++;
                    }
                }
                left++;

            }
        }
    }
}

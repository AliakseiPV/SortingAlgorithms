﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithm
{
    public class AlgorithmBase<T> 
    {
        public int SwapCount { get; protected set; } = 0;
        public int ComparisonCount { get; protected set; } = 0;

        public List<T> Items { get; set; } = new List<T>();

        protected void Swap(int positionA, int positionB)
        {
            if(positionA < Items.Count && positionB < Items.Count)
            {
                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;

                SwapCount++;
            }
        }

        public TimeSpan Sort()
        {
            Stopwatch timer = new Stopwatch();
            SwapCount = 0;

            timer.Start();
            MakeSort();
            timer.Stop();

            return timer.Elapsed;
        }

        protected virtual void MakeSort()
        {
            Items.Sort();
        }
    }
}

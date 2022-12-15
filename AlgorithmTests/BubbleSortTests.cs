using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Algorithm.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            BubbleSort<int> bubble = new BubbleSort<int>();

            Random random = new Random();
            List<int> items = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                items.Add(random.Next(0, 100));
            }

            bubble.Items.AddRange(items);

            bubble.Sort();
            items.Sort();

            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], bubble.Items[i]);
            }
            
        }
    }
}
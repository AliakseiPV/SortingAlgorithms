using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Tests
{
    [TestClass()]
    public class SortTest
    {
        Random random = new Random();
        List<int> Items = new List<int>();
        List<int> Sorted = new List<int>();

        [TestInitialize]
        public void Init()
        {
            Items.Clear();
            Sorted.Clear();

            for (int i = 0; i < 10000; i++)
            {
                Items.Add(random.Next(0, 1000));
            }

            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }

        [TestMethod()]
        public void BubbleTest()
        {
            BubbleSort<int> bubble = new BubbleSort<int>();
            bubble.Items.AddRange(Items);

            bubble.Sort();
            MatchCheck(bubble);
        }

        [TestMethod()]
        public void CocktailTest()
        {
            CocktailSort<int> cocktail = new CocktailSort<int>();
            cocktail.Items.AddRange(Items);

            cocktail.Sort();
            MatchCheck(cocktail);
        }

        [TestMethod()]
        public void InsertionTest()
        {
            InsertionSort<int> insert = new InsertionSort<int>();
            insert.Items.AddRange(Items);

            insert.Sort();
            MatchCheck(insert);
        }

        private void MatchCheck(AlgorithmBase<int> sort)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], sort.Items[i]);
            }
        }
    }
}
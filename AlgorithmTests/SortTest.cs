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

        [TestMethod()]
        public void ShellTest()
        {
            ShellSort<int> shell = new ShellSort<int>();
            shell.Items.AddRange(Items);
            shell.Sort();
            MatchCheck(shell);
        }

        [TestMethod()]
        public void TreeTest()
        {
            TreeSort<int> tree = new TreeSort<int>();
            tree.Items.AddRange(Items);
            tree.Sort();
            MatchCheck(tree);
        }

        [TestMethod()]
        public void HeapTest()
        {
            HeapSort<int> heap = new HeapSort<int>();
            heap.Items.AddRange(Items);
            heap.Sort();
            MatchCheck(heap);
        }

        [TestMethod()]
        public void BaseSortTest()
        {
            AlgorithmBase<int> baseSort = new AlgorithmBase<int>();
            baseSort.Items.AddRange(Items);
            baseSort.Sort();
            MatchCheck(baseSort);
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
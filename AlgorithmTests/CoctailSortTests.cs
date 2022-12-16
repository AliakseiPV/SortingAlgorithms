using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Tests
{
    [TestClass()]
    public class CoctailSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            CoctailSort<int> coctail = new CoctailSort<int>();

            Random random = new Random();
            List<int> items = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                items.Add(random.Next(0, 100));
            }

            coctail.Items.AddRange(items);

            coctail.Sort();
            items.Sort();

            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], coctail.Items[i]);
            }
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortLibrary.Tests
{
    [TestClass()]
    public class CocktailSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            //arrange
            var cocktail = new CocktailSort<int>();

            var rnd = new Random();
            var items = new List<int>();

            for (int i = 0; i < 8000; i++)
            {
                items.Add(rnd.Next(0, 1000));
            }

            cocktail.Items.AddRange(items);
            var sorted = items.OrderBy(x => x).ToArray();

            //act
            cocktail.Sort();

            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], cocktail.Items[i]);
            }
        }
    }
}
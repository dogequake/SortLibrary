using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortLibrary
{
    public class BubbleSort<T> : AlgorithmBase<T> where T: IComparable
    {
        public override void Sort()
        {
            SwopCount = 0;
            var count = Items.Count;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    var firstElement = Items[j];
                    var secondElement = Items[j + 1];

                    if (firstElement.CompareTo(secondElement) == 1)
                    {
                        Swop(j, j + 1);

                        ComparisonCount++;
                    }
                }
            }
        }
    }
}

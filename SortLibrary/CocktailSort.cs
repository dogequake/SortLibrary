using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortLibrary
{
    public class CocktailSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            SwopCount = 0;
            int left = 0;
            int right = Items.Count - 1;

            while (left < right) 
            {
                var sc = SwopCount;

                for (int i = left; i < right; i++)
                {
                    if (Items[i].CompareTo(Items[i + 1]) == 1)
                    {
                        Swop(i, i + 1);

                        ComparisonCount++;
                    }
                }
                right--;

                if (sc == SwopCount)
                {
                    break;
                }

                for (int i = right; i > left; i--)
                {
                    if (Items[i].CompareTo(Items[i - 1]) == -1)
                    {
                        Swop(i, i - 1);

                        ComparisonCount++;
                    }
                }
                left++;

                if (sc == SwopCount)
                {
                    break;
                }
            }
        }
    }
}

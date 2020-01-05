using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSorter.Sorting_Algorithm
{
    class Selection : ISort
    {
        public IList<decimal> Sort(IList<decimal> vault)
        {
            decimal n = vault.Count;

            // One by one move boundary of unsorted subarray 
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array 
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (vault[j] < vault[min_idx])
                    {
                        min_idx = j;
                    }
                }

                // Swap the found minimum element with the first element 
                decimal temp = vault[min_idx];
                vault[min_idx] = vault[i];
                vault[i] = temp;
            }

            return vault;
        }
    }   
}

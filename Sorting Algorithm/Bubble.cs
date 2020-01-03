using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSorter.Sorting_Algorithm
{
    class Bubble : ISort
    {
        public IList<Decimal> Sort(IList<Decimal> vault)
        {
            Decimal n = vault.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (vault[j] > vault[j + 1])
                    {
                        // swap temp and arr[i] 
                        Decimal temp = vault[j];
                        vault[j] = vault[j + 1];
                        vault[j + 1] = temp;
                    }
                }
            }

            return vault;
        }
    }
}
